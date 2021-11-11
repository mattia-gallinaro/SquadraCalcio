using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    class Squadra
    {
        public string nomesquadra { get; set; }//variabile contenente il nome della squadra
        int partite_vinte, partite_perse, partite_pareggiate, gol_fatti, gol_subiti, punteggio, punteggio_totale;//attributi della classe Squadra
        public Squadra()//inizializza gli attributi per la squadra corrente
        {
            nomesquadra = "";// il nome della squadra corrente
            partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" della squadra corrente
            partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" della squadra corrente
            partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" della squadra corrente
            gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" della squadra corrente
            gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" della squadra corrente
            punteggio = 0;//porta a 0 il valore della variabile "punteggio" della squadra corrente
            punteggio_totale = 0;//porta a 0 il valore della variabile "punteggio_totale" della squadra corrente
        }
        public int ControlloQuantità()//controllo che il valore inserito dall'utente sia un numero e che sia maggiore di 0, se non lo è allora ritorna -1
        {
            try//utilizzo "try" per controllare il valore che l'utente inserisce come risposta
               //utilizzo "catch" per gestire gli errori come nel caso in cui l'utente inserisce da tastiera qualcosa che non sia un numero
            {
                int risposta = int.Parse(Console.ReadLine());//legge il valore inserito in input da tastiera, lo converte in intero e lo assegna alla variabile risposta
                if(risposta < 0)//controlla che il valore che l'utente abbia inserito sia minore di 0 e se ciò si verifica allora ritorna -1
                {
                    return -1;
                }
                else//se il valore che l'utente scrive è maggiore od uguale a 0 viene fatto il return della variabile risposta
                {
                    return risposta;//ritorna il valore che l'utente ha inserito da tastiera 
                }       
            }
            catch
            {
                return -1;//ritorna -1 se il valore inserito dall'utente non rispetta le condizioni
            }
        }
        public bool NomiSoloDiversi(string[] nomi, string nome)//serve per controllare che il nome inserito dall'utente non sia già stato inserito come nome di un'altra squadra
        {
            bool controllo = false;//variabile booleana per il controllo dei nomi
            for(int i = 0; i < nomi.Length && !controllo; i++)//ciclo for che si ripete fino a quando controllo rimane false oppure appena i raggiunge la grandezza di i
            {
                 if(nomi[i] == nome)//controlla se il nome inserito dall'utente corrisponde ad uno dei nomi già inseriti
                 {
                    controllo = true;//pone il valore di controllo a true
                 }
            }
            return controllo;//ritorna il valore di controllo
        }
        public List<Squadra> CreaSqaudre(string[] nomi)//serve per creare ed assegnare 
        {
            List<Squadra> creazione = new List<Squadra>();//lista per la creazione delle squadre
            for(int i  = 0; i < nomi.Length; i++)//ripeto il ciclo per la quantità di squadre che devono essere create
            {
                creazione.Add(new Squadra());//aggiunge una nuova riga nella lista creazione 
                creazione[i].nomesquadra = nomi[i];//assegno all'elemento appena creato, il nome in corrispondenza dell'indice i 
            }
            return creazione;//ritorno la lista completa di squadre
        }
        public void AumentoPartite()//in base al valore degli attributi gol_fatti e gol_subiti e aumenta il numero di partite vinte, perse oppure pareggiate dell'istanza corrente 
        {
            if (gol_fatti < gol_subiti)//controlla se il numero di gol_fatti della squadra corrente siano minori dei gol_subiti 
                                       //se si verifica questa condizione allora verrà aumentata la variabile partite_perse della squadra corrente di 1
            {
                partite_perse++;//aumenta la variabile partite_perse della squadra corrente 
            }
            else if (gol_fatti == gol_subiti)//controlla che il numero di gol fatti siano lo stesso del numero di gol subiti
            {
                partite_pareggiate++;//aumenta di 1 il numero delle partite pareggiate della squadra corrente 
            }
            else
            {
                partite_vinte++;//aumenta di 1 il numero delle partite vinte della squadra corrente 
            }       
        }
        public void Punti()//calcola il punteggio della squadra basato sul numero di vittorie ed il numero di pareggi della squadra corrente
        {
            punteggio = (partite_vinte * 3) + (partite_pareggiate * 1);//assegna alla variabile punteggio della squadra corrente,lo somma tra il numero delle partite vinte dalla squadra corrente moltiplicato per 3 ed il numero delle partite pareggiate della squadra corrente                                                                          //
        }
        public void Gol_Fatti(int gol)//assegna il valore di gol fatti alla variabile gol_fatti e li aggiunge alla variabile totale_gol_fatti della squadra corrente
        {
            gol_fatti = gol;//assegna il numero di gol che l'utente ha inserito da tastiera alla variabile gol_fatti della squadra corrente
        }
        public void Gol_Subiti(int gol)//assegna il valore di gol subiti alla variabile gol_subiti e li aggiunge alla variabile totale_gol_subiti
        {
            gol_subiti = gol;//assegna il valore di gol alla variabile gol_subiti della squadra corrente
        }
        public void AssegnazioneValori(int[] valori)//assegna i valori specificati dall'utente alla squadra corrente
        {
            partite_vinte = valori[0];//assegna il primo valore che l'utente ha inserito da tastiera alla variabile "partite_vinte" della squadra corrente
            partite_pareggiate = valori[1];//assegna il secondo valore che l'utente ha inserito da tastiera alla variabile "partite_pareggiate" della squadra corrente
            partite_perse = valori[2];//assegna il terzo valore che l'utente ha inserito da tastiera alla variabile "partite_perse" della squadra corrente
        }
        public void InizioAnno()//riporta i valori a zero degli attributi
        {
            partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" della squadra corrente
            partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" della squadra corrente
            partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" della squadra corrente
            gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" della squadra corrente
            gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" della squadra corrente
        }
        public int[] GenerazionePartite(int quantita)//genero gli indici della lista delle squadre per le partite in modo e senza doppioni
        {
            int[] array  = new int[quantita];//array che contiene gli indici da generare per le partite
            Random random = new Random();//crea un'istanza della classe Random
            int numero_generato = 0;//variabile che contiene il numero generato
            bool controllo = false;//variabile booleana usata per il controllo nella generazione di doppioni
            for(int i = 0; i< array.Length; i++)//for che si ripete per il numero di squadre inserite dall'utente
            {
                numero_generato = random.Next(0, quantita);//viene richiamata la funzione Next della classe Random dando come parametri 0 ed quantità
                if(i >= 1)//inizia a controllare appena avrà generato il secondo numero
                {
                    for (int j = 0; j < i; j++)//for usato per il controllo dei doppioni
                                               //si ripete fino a quando j raggiunge il valore di i
                    {
                        if(array[j] == numero_generato)//controlla che il numero appena generato non corrisponda ad un numero già presente in array
                        {
                            controllo = true;//se è un doppione allora cambio il valore di controllo e lo rendo true
                        }
                                
                    }
                }
                else//se è il primo numero ad esse generato
                {
                    array[i] = numero_generato;
                }
                if (controllo)//se si tratta di un doppione fa ripetere la generazione del numero 
                {
                    i--;//diminuisce il valore di i di 1 per far ripetere la generazione del numero
                    controllo = false;//riporto il valore di controllo a false sennò non terminerebbe mai la generazione dei numeri
                }
                else//se il numero generato non è doppione
                {
                    array[i] = numero_generato;//salvo il numero appena generato in array nella posizione i
                }
            }
            return array;//ritorno l'array con gli indici delle partite
        }
        public int GestionePartita(ref List<Squadra> giocatori, int[] valori, int indice1, int indice2)
        {
            giocatori[indice1].Gol_Fatti(valori[3]);//invoca la funzione Gol_Fatti per la squadra nella posizione indice1 della lista giocatori e passo valori[3] che corrisponde al numero di gol fatti dalla prima squadra della partita
            giocatori[indice2].Gol_Fatti(valori[4]);//invoca la funzione Gol_Fatti per la squadra nella posizione indice2 della lista giocatori e passo valori[4] che corrisponde al numero di gol fatti dalla seconda squadra della partita
            giocatori[indice1].Gol_Subiti(valori[4]);//invoca la funzione Gol_Subiti per la squadra nella posizione indice1 della lista giocatori e passo valori[4] che corrisponde al numero di gol fatti dalla seconda squadra della partita
            giocatori[indice2].Gol_Subiti(valori[3]);//invoca la funzione Gol_Subiti per la squadra nella posizione indice2 della lista giocatori e passo valori[3] che corrisponde al numero di gol fatti dalla prima squadra della partita
            giocatori[indice1].AumentoPartite();//invoca la funzione AumentoPartite per la squadra nella posizione indice1 della lista giocatori
            giocatori[indice2].AumentoPartite();//invoca la funzione AumentoPartite per la squadra nella posizione indice2 della lista giocatori
            giocatori[indice1].Punti();//invoca la funzione Punti per la squadra nella posizione indice1 della lista giocatori
            giocatori[indice2].Punti();//invoca la funzione Punti per v nella posizione indice2 della lista giocatori
            if (valori[3] > valori[4])//controlla se il numero di gol fatti della prima squadra è maggiore di quelli della seconda 
                                      //se ciò si verifica allora viene eseguito il codice dentro l'if
            {
                return 2;//ritorna 2 che corrisponde alla vittoria del,a prima squadra
            }
            else if (valori[3] < valori[4])//controlla se il numero di gol fatti della seconda squadra è maggiore di quella della prima squadra
                                           //se ciò si verifica allora viene eseguito il codice dentro l'if
            {
                return 1;//ritorna 1 che corrisponde alla vittoria della seconda squadra
            }
            else
            {
                return 0;//ritorna 0 che corrisponde alla pareggio nella partita 
            }
        }
        public void ClassificaProvvisoria(ref List<Squadra> giocatori)//funzione per riordinare le squadre in ordine decrescente in base al punteggio di ciascuna di esse, tramite bubble sort
        {
            bool controllo;//variabile booleana
            do
            {
                controllo = false;//riassegna false a controllo sennò continuerebbe all'infinito
                for (int i = 0; i < (giocatori.Count - 1); i++)//il ciclo si ripete per la quantità di squadre presenti nella lista bubble diminuito di 1
                {
                    if (giocatori[i].punteggio < giocatori[i + 1].punteggio)//controlla se il punteggio della squadra in posizione i della lista bubble sia minore del punteggio della squadra in posizione successiva ad i nella lista bubbble
                    {
                        giocatori.Reverse(i, 2);//scambio i due elementi della lista 
                        controllo = true;
                    }
                }
            } while (controllo);//si ripete fino a quando il valore della variabile booleana corrisponde a false
        }
        public void ClassificaDefinitiva(ref List<Squadra> bubble)//funzione per riordinare le squadre in ordine decrescente in base al punteggio_totale di ciascuna di esse, tramite bubble sort
        {
            bool controllo;//variabile booleana
            do
            {
                controllo = false;//riassegna false a controllo sennò continuerebbe all'infinito
                for (int i = 0; i < (bubble.Count - 1); i++)//il ciclo si ripete per la quantità di squadre presenti nella lista bubble diminuito di 1
                {
                    if (bubble[i].punteggio_totale < bubble[i+1].punteggio_totale)//controlla se il punteggio totale della squadra in posizione i della lista bubble sia minore del punteggio totale della squadra in posizione successiva ad i nella lista bubbble
                    {
                        bubble.Reverse(i, 2);//scambia l'elemento con indici pari ad i della lista con quello successivo
                        controllo = true;
                    }
                }
            } while (controllo);//si ripete fino a quando non finiscono gli scambi e controllo rimane false

        }
        public void IncrementoPunteggio()//aumenta il punteggio_totale della squadra corrente
        {
            punteggio_totale = punteggio_totale + punteggio;
        }
        public override string ToString()//ritorna una stringa in cui mostra il numero di partite vinte, di partite pareggiate e di partite perse della squadra corrente
        {
            return $"Numero partite vinte: {partite_vinte}\nNumero partite pareggiate: {partite_pareggiate}\nNumero partite perse: {partite_perse}\n";
        }

        static void Main(string[] args)
        {
            List<Squadra> squadre = new List<Squadra>();//lista contenente le squadre che giocheranno
            Squadra squadra = new Squadra();//crea un'istanza della classe Squadra 
            int risposta;//variabile int in cui verrà salvato il 
            string[] nomi;//array di stringhe che contiene i nomi delle squadrre
            string selezione;//variabile che contiene il nome che viene inserito dall'utente
            do
            {
                Console.WriteLine("Inserisci il numero di squadre che deve pari e maggiore od uguale a 2");//scrive all'utente la stringa compresa fra le parentesi tonde
                risposta = squadra.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra che ritorna un intero
            } while (risposta < 2 || risposta % 2 != 0);//continua a chiedere la quantità di squadre da inserire fino a quando l'utente inserisce un numero pari maggiore o uguale a 2
            nomi = new string[risposta];//assegna ad nomi, una grandezza corrispondente al numero di squadre che l'utente vuole creare
            for(int i = 0; i < risposta; i++)
            {
                Console.WriteLine($"Inserisci il nome della squadra numero {i+1}");
                selezione = Console.ReadLine();//assegna alla stringa selezione, ciò che l'utente scrive
                if(squadra.NomiSoloDiversi(nomi, selezione))//invoca il metodo NomiSoloDiversi passando come parametri l'array nomi e la stringa selezione,
                                                            //se ritorna true allora il nome appena inserito dall'utente esiste già e fa ripetere il ciclo
                                                            //sennò il nome appena inserito viene assegnato nell'array nomi all'indice i
                {
                    Console.WriteLine("Questo nome e' gia' stato inserito");
                    i--;
                }
                else
                {
                    nomi[i] = selezione;
                }
            }
            squadre = squadra.CreaSqaudre(nomi);//invoca il metodo CreaSquadre passando come parametro, l'array nomi, e ritorna la lista che viene assegnata alla lista squadre
            int[] risposte = new int[6];//array di interi per immagazzinare le risposte dell'utente che verranno usate per assegnare le variabili 
            for (int i = 0; i < squadre.Count; i++)
            {
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite vinte della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite pareggiate della (nome della squadra)"
                    risposte[0] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al primo livello dell'array risposte
                } while (risposte[0] < 0);
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite pareggiate della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite pareggiate della (nome della squadra)"
                    risposte[1] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al secondo livello dell'array risposte
                } while (risposte[1] < 0);
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite perse della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite pareggiate della (nome della squadra)"
                    risposte[2] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al terzo livello dell'array risposte
                } while (risposte[2] < 0);
                squadre[i].AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Juventus e come argomento pone l'array contenente le risposte alle domande sopra 
            }
            Console.Clear();//elimina tutto ciò che è stato scritto a schermo fin'ora
            for( int  i = 0; i < squadre.Count; i++)
            {
                Console.WriteLine($"{squadre[i].nomesquadra}");
                Console.WriteLine($"{squadre[i].ToString()}");
            }
            int[] indici;//array di interi che contiene gli indici delle squadre per le partite
            string answer;//stringa che contiene la risposta per terminare o far continuare il campionato
            do
            {
                answer = "";
                for (int c = 0 ; c < 365 && answer != "No"; c++)
                {
                    Console.WriteLine($"Giornata {c + 1} di 365");
                    indici = squadra.GenerazionePartite(squadre.Count);
                    int n1 = 0;
                    for (int i = 0; i < indici.Length; i+=2)//ciclo for che si ripete per la grandezza dell'array indici e ad ogni ciclio viene aumentato di 2 perchè con ogni ciclo viene fatta la partita tra due squadre
                    {
                        n1++;
                        Console.WriteLine($"Girone {n1} di {indici.Length/2}");
                        do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                        {
                            Console.WriteLine($"Inserisci il numero di gol fatti dalla squadra {squadre[i].nomesquadra}");
                            risposte[3] = squadra.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quarto livello dell'array risposte
                        } while (risposte[3] < 0);
                        do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                        {
                            Console.WriteLine($"Inserisci il numero di gol fatti dalla squadra {squadre[i+1].nomesquadra}");
                            risposte[4] = squadra.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quinto livello dell'array risposte
                        } while (risposte[4] < 0);

                        risposte[5] = squadra.GestionePartita(ref squadre,risposte, indici[i], indici[i+1]);//invoca la funzione GestionePartita e il valore che ritorna viene assegnato ad risposte[5]
                        if(risposte[5] == 2)//nel caso in cui il valore ritornato corrisponde a 2
                        {
                            Console.WriteLine($"in questa partita ha vinto la squadra {squadre[i].nomesquadra}");//viene scritto a schermo che la prima squadra delle due squadre della partita, ha vinto 
                        }
                        else if(risposte[5] == 1)//nel caso in cui il valore ritornato corrisponde a 1
                        {
                            Console.WriteLine($"In questa partita ha vinto la squadra {squadre[i+1].nomesquadra}");//viene scritto a schermo che la prima squadra delle due squadre della partita, ha vinto 
                        }
                        else//nel caso in cui il valore ritornato corrisponde a 0
                        {
                        Console.WriteLine("Questa partita è terminata in pareggio");//viene scritto a schermo che la partita è terminata con il pareggio delle due squadre
                        }
                    }
                    Console.WriteLine("Scrivi No per terminare l'anno");//viene scritto a schermo cosa l'utente deve scrivere per terminare l'anno
                    answer = Console.ReadLine();//assegna ciò che l'utente scrive alla stringa answer
                }
                squadra.ClassificaProvvisoria(ref squadre);//invoca il metodo ClassificaProvvisoria che ordina la lista squadre in base al punteggio di ogni squadra
                for(int i  = 0; i < squadre.Count; i++)//scrive la classifica della lista squadre e per ogni elemento invoca la funzoine IncrementoPunteggio e InizioAnno
                {
                    Console.WriteLine($"In {i+1}° posizione abbiamo la squadra {squadre[i].nomesquadra}");
                    squadre[i].IncrementoPunteggio();
                    squadre[i].InizioAnno();
                }
                Console.WriteLine("Scrivi yes o y per terminare il campionato");//viene scritto a schermo cosa l'utente deve scrivere per terminare il campionato
                answer = Console.ReadLine();//assegna ciò che l'utente scrive alla stringa answer
            } while (answer != "yes" && answer != "y");
            squadra.ClassificaDefinitiva(ref squadre);//invoca il metodo ClassificaProvvisoria che ordina la lista squadre in base al punteggio di ogni singola squadra
            for (int i = 0; i < squadre.Count; i++)//scrive la classifica della lista squadre
            {
                Console.WriteLine($"In {i + 1}° posizione abbiamo la squadra {squadre[i].nomesquadra}");
            }
            Console.WriteLine("Grazie per aver giocato ");
        }
    }
}
