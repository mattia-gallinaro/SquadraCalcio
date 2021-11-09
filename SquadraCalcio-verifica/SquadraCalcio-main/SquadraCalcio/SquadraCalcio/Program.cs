using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    class Squadra
    {
        public string nomesquadra { get; set; }
        int partite_vinte, partite_perse, partite_pareggiate, gol_fatti, gol_subiti, punteggio, punteggio_totale;//attributi della classe Squadra
        public Squadra()//porta a 0 il valore degli attributi
        {
            this.nomesquadra = "";
            this.partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" nell'istanza corrente
            this.partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" nell'istanza corrente
            this.partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" nell'istanza corrente
            this.gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" nell'istanza corrente
            this.gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" nell'istanza corrente
            this.punteggio = 0;//porta a 0 il valore della variabile "punteggio" nell'istanza corrente
            this.punteggio_totale = 0;//porta a 0 il valore della variabile "punteggio_totale" nell'istanza corrente
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
                return -1;//
            }
        }
        public bool NomiSoloDiversi(string[] nomi, string nome)//controllo che il nome inserito non sia già stato inserito come nome di un'altra squadra
        {
            bool controllo = false;
            for(int i = 0; i < nomi.Length && !controllo; i++)
            {
                 if(nomi[i] == nome)
                {
                    controllo = true;
                }
            }
            return controllo;
        }
        public List<Squadra> CreaSqaudre(string[] nomi)
        {
            List<Squadra> creazione = new List<Squadra>();
            for(int i  = 0; i < nomi.Length; i++)
            {
                creazione.Add(new Squadra());
                creazione[i].nomesquadra = nomi[i];
            }
            return creazione;
        }
        public void AumentoPartite()//in base al valore degli attributi gol_fatti e gol_subiti e aumenta il numero di partite vinte, perse oppure pareggiate dell'istanza corrente 
        {
            if (this.gol_fatti < this.gol_subiti)//controlla se il numero di gol_fatti siano minori dei gol_subiti
                                                 //se si verifica questa condizione allora verrà aumentata la variabile partite
            {
                this.partite_perse++;//aumenta la variabile partite_perse dell'istanza corrente 
            }
            else if (this.gol_fatti == this.gol_subiti)//controlla che il numero di gol fatti siano lo stesso del numero di gol subiti
            {
                this.partite_pareggiate++;//aumenta di 1 il numero delle partite pareggiate dell'istanza corrente 
            }
            else
            {
                this.partite_vinte++;//aumenta di 1 il numero delle partite vinte dell'istanza corrente 
            }       
        }
        public void Punti()//calcola il punteggio della squadra basato sul numero di vittorie ed il numero di pareggi dell'istanza corrente
        {
            this.punteggio = (this.partite_vinte * 3) + (this.partite_pareggiate * 1);//assegna alla variabile punteggio dell'istanza corrente,lo somma tra il numero delle partite vinte dalla squadra corrente moltiplicato per 3 ed il numero delle partite pareggiate della squadra corrente                                                                          //
            this.IncrementoPunteggio();
            //return this.punteggio;//ritorna il punteggio della squadra corrente
        }
        public void Gol_Fatti(int gol)//assegna il valore di gol fatti alla variabile gol_fatti e li aggiunge alla variabile totale_gol_fatti dell'istanza corrente
        {
            this.gol_fatti = gol;//assegna il numero di gol che l'utente ha inserito da tastiera alla variabile gol_fatti dell'istanza corrente
        }
        public void Gol_Subiti(int gol)//assegna il valore di gol subiti alla variabile gol_subiti e li aggiunge alla variabile totale_gol_subiti
        {
            this.gol_subiti = gol;//assegna il valore di gol alla variabile gol_subiti dell'istanza corrente
        }
        public void AssegnazioneValori(int[] valori)//assegna i valori specificati dall'utente all'istanza corrente quindi prima alla Juventus e dopo al Milan
        {
            this.partite_vinte = valori[0];//assegna il primo valore che l'utente ha inserito da tastiera alla variabile "partite_vinte" dell'istanza corrente
            this.partite_pareggiate = valori[1];//assegna il secondo valore che l'utente ha inserito da tastiera alla variabile "partite_pareggiate" dell'istanza corrente
            this.partite_perse = valori[2];//assegna il terzo valore che l'utente ha inserito da tastiera alla variabile "partite_perse" dell'istanza corrente
        }
        public void InizioAnno()//riporta i valori a zero degli attributi della squadra corrente
        {
            this.partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" nell'istanza corrente
            this.partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" nell'istanza corrente
            this.partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" nell'istanza corrente
            this.gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" nell'istanza corrente
            this.gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" nell'istanza corrente
        }
        public void ScambioValori(ref int[] risposte)//scambia il valore delle partite vinte con il valore delle partite perse della
                                                     //ed il valore delle partite perse con quelle vinte 
        {
            int n3;//variabile per lo scambio
            n3 = risposte[0];//assegna il valore di risposte[0] alla variabile per lo scambio
            risposte[0] = risposte[2];//assegna il valore di risposte[2] ad risposte[0]
            risposte[2] = n3;//assegna il valore della variabile di scambio, quindi risposte[0], a risposte[2]
        }
        public int[] GenerazionePartite(List<Squadra> squadrone)//genero gli indici della lista delle squadre in modo e senza doppioni
                                                                //in seguito verranno raggruppati a due a due
        {
            int[] array  = new int[squadrone.Count];
            Random random = new Random();
            int numero_generato = 0;
            bool controllo = false;
            for(int i = 0; i< array.Length; i++)
            {
                numero_generato = random.Next(0, squadrone.Count);
                if(i >= 1)//inizia a controllare appena avrà generato il secondo numero
                {
                    for (int j = 0; j < i; j++)
                    {
                        if(array[j] == numero_generato)
                        {
                            controllo = true;
                        }
                                
                    }
                }
                else
                {
                    array[i] = numero_generato;
                }
                if (controllo)//se si tratta di un doppione fa ripetere la generazione del numero 
                {
                    
                    i--;
                    controllo = false;
                }
                else
                {
                    array[i] = numero_generato;
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine($"{i}");
            }
            return array;
        }
        public int GestionePartita(ref List<Squadra> wewewewe, int[] valori, int indice1, int indice2)
        {
            wewewewe[indice1].Gol_Fatti(valori[3]);
            wewewewe[indice2].Gol_Fatti(valori[4]);
            wewewewe[indice1].AumentoPartite();
            wewewewe[indice2].AumentoPartite();
            wewewewe[indice1].Punti();
            wewewewe[indice2].Punti();
            if (valori[3] > valori[4])
            {
                return 2;
            }
            else if (valori[3] < valori[4])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //per entrambi i due metodi successivi verranno riordinati tramite bubble sort, in caso di punteggi uguali verrà controllato anche il numero di gol segnati totali
        public void ClassificaProvvisoria(ref List<Squadra> scarsoni)
        {
            bool controllo;
            do
            {
                controllo = false;
                for(int i  = 0; i < (scarsoni.Count-1); i++)
                {
                    if(scarsoni[i].punteggio < scarsoni[i+1].punteggio)
                    {
                        scarsoni.Reverse(i, 2);//scambio i due elementi della lista 
                        controllo = true;
                    }
                }
            } while (controllo);
        }
        //per entrambi i due metodi successivi verranno riordinati tramite bubble sort, in caso di punteggi uguali verrà controllato anche il numero di gol segnati totali
        public void ClassificaDefinitiva(ref List<Squadra> bubble)
        {
            bool controllo;
            do
            {
                controllo = false;
                for (int i = 0; i < (bubble.Count - 1); i++)
                {
                    if (bubble[i].punteggio_totale < bubble[i+1].punteggio_totale)
                    {
                        bubble.Reverse(i, 2);//scambio i due elementi della lista 
                        controllo = true;
                    }
                }
            } while (controllo);

        }
        public void IncrementoPunteggio()
        {
            this.punteggio_totale = this.punteggio_totale + this.punteggio;
        }
        public int ReturnPunteggioTotale()
        {
            return this.punteggio_totale;
        }
        public override string ToString()//ritorna una stringa in cui mostra il numero di partite vinte, di partite pareggiate e di partite perse della squadra corrente
        {
            return $"Numero partite vinte: {this.partite_vinte}\nNumero partite pareggiate: {this.partite_pareggiate}\nNumero partite perse: {this.partite_perse}\n";
        }

        static void Main(string[] args)
        {
            List<Squadra> squadre = new List<Squadra>();
            Squadra squadra = new Squadra();
            int risposta;
            string[] nomi;
            string selezione;
            do
            {
                Console.WriteLine("Inserisci il numero di squadre");
                risposta = squadra.ControlloQuantità();
            } while (risposta < 2 || risposta % 2 != 0);
            nomi = new string[risposta];
            for(int i = 0; i < risposta; i++)
            {
                Console.WriteLine($"Inserisci il nome della squadra numero {i+1}");
                selezione = Console.ReadLine();
                if(squadra.NomiSoloDiversi(nomi, selezione))
                {
                    Console.WriteLine("Questo nome e' gia' stato inserito");
                    i--;
                }
                else
                {
                    nomi[i] = selezione;
                }
            }
            squadre = squadra.CreaSqaudre(nomi);
            int[] risposte = new int[6];//array di interi per immagazzinare le risposte dell'utente che verranno usate per assegnare le variabili 
            for (int i = 0; i < squadre.Count; i++)
            {
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite vinte della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite vinte della Juventus"
                    risposte[0] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al primo livello dell'array risposte
                } while (risposte[0] < 0);
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite pareggiate della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite pareggiate della Juventus"
                    risposte[1] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al secondo livello dell'array risposte
                } while (risposte[1] < 0);
                do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                {
                    Console.WriteLine($"Inserisci le partite perse della {squadre[i].nomesquadra}");//scrive a schermo "Inserisci le partite perse della Juventus"
                    risposte[2] = squadre[i].ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al terzo livello dell'array risposte
                } while (risposte[2] < 0);
                squadre[i].AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Juventus e come argomento pone l'array contenente le risposte alle domande sopra 
            }
            Console.Clear();
            for( int  i = 0; i < squadre.Count; i++)
            {
                Console.WriteLine($"{squadre[i].ToString()}");
            }
            //squadre[risposta].AssegnazioneValori();
            //Squadra Juventus = new Squadra();//crea l'oggetto Juventus della classe Squadra
            //Squadra Milan = new Squadra();//crea l'oggetto Milan della classe Squadra
            int[] indici;
            string answer;
            do
            {
                answer = "";
                for (int c = 0 ; c < 365 && answer != "No"; c++)
                {
                    Console.WriteLine($"Giornata {c + 1} di 365");
                    indici = squadra.GenerazionePartite(squadre);
                    for (int i = 0; i < indici.Length; i+=2)
                    {
                        Console.WriteLine($"Girone {i+1} di {indici.Length/2}");
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

                        risposte[5] = squadra.GestionePartita(ref squadre,risposte, indici[i], indici[i+1]);
                        if(risposte[5] == 2)
                        {
                            Console.WriteLine($"in questa partita ha vinto la squadra {squadre[i].nomesquadra}");
                        }
                        else if(risposte[5] == 1)
                        {
                            Console.WriteLine($"In questa partita ha vinto la squadra {squadre[i+1].nomesquadra}");
                        }
                        else
                        {
                        Console.WriteLine("Questa partita è terminata in pareggio");
                        }
                    }
                    Console.WriteLine("Scrivi No per terminare l'anno");
                    answer = Console.ReadLine();
                }
                squadra.ClassificaProvvisoria(ref squadre);
                for(int i  = 0; i < squadre.Count; i++)
                {
                    Console.WriteLine($"In {i+1}° posizione abbiamo la squadra {squadre[i].nomesquadra}");
                    squadre[i].InizioAnno();
                }
                Console.WriteLine("Scrivi yes o y per terminare il campionato");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "y");
            squadra.ClassificaDefinitiva(ref squadre);
            for (int i = 0; i < squadre.Count; i++)
            {
                Console.WriteLine($"In {i + 1}° posizione abbiamo la squadra {squadre[i].nomesquadra}");
            }
            Console.WriteLine("Grazie per aver giocato ");
            Console.WriteLine("IL codicce è ancora in continuazione");
            /*do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite vinte della Juventus");//scrive a schermo "Inserisci le partite vinte della Juventus"
                risposte[0] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al primo livello dell'array risposte
            } while (risposte[0] < 0);
            do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite pareggiate della Juventus");//scrive a schermo "Inserisci le partite pareggiate della Juventus"
                risposte[1] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al secondo livello dell'array risposte
            } while (risposte[1] < 0);
            do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite perse della Juventus");//scrive a schermo "Inserisci le partite perse della Juventus"
                risposte[2] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al terzo livello dell'array risposte
            } while (risposte[2] < 0);*/

            /*Juventus.AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Juventus e come argomento pone l'array contenente le risposte alle domande sopra 

            Console.WriteLine("\nDati Juventus:\n");
            Console.WriteLine(Juventus.ToString());//invoca la funzione ToString() della classe Squadra per l'oggetto Juventus che ritorna una stringa contenente i dati inseriti dall'utente 
            
            //non faccio inserire i dati anche al Milan perchè sono l'opposto di quelli della Juventus dato che sono le uniche due squadre nel campionato e quindi le partite vinte della prima squadra sono quelle perse della seconda squadra 
            Console.WriteLine("\nDati Milan:\n");
            Milan.ScambioValori(ref risposte);//invoca la funzione ScambioValori della classe Squadra per invertire le partite vinte della Juventus con le partite perse della Juventus nell'array risposte
            Milan.AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Milan e come argomento pone l'array contenente le risposte alle domande sopra 
            Console.WriteLine(Milan.ToString());//invoca la funzione ToString() della classe Squadra per l'oggetto Milan che ritorna una stringa contenente i dati inseriti dall'utente 
            answer = "";//stringa per terminare l'anno ed il campionato
            do
            {
                answer = "";
                for(int i = 0; i < 365 && answer != "yes"; i++)//continua a far giocare le squadre per un'anno intero oppure termina l'anno appena l'utente scrive yes alla che precede il ripetersi del ciclo
                {
                    Console.WriteLine($"Partita n°{i+1} di 365");
                    do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Juventus");
                        risposte[3] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quarto livello dell'array risposte
                    } while (risposte[3] < 0);
                    do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Milan");
                        risposte[4] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quinto livello dell'array risposte
                    } while (risposte[4] < 0);
                    Juventus.Gol_Fatti(risposte[3]);
                    Juventus.Gol_Subiti(risposte[4]);
                    Milan.Gol_Fatti(risposte[4]);
                    Milan.Gol_Subiti(risposte[3]);
                    Milan.AumentoPartite();
                    Juventus.AumentoPartite();
                    Console.WriteLine("Scrivi yes per terminare l'anno");
                    answer = Console.ReadLine();
                }
                Console.WriteLine($"La squadra Juventus ha totalizzato {Juventus.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato nell'anno
                Console.WriteLine($"La squadra Milan ha totalizzato {Milan.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato nell'anno
                if (Juventus.Punti() < Milan.Punti())//invoca la funzione Punti della classe Squadra sia per l'oggetto Juventus che per Milan e se il valore dei punti della squadra Juventus è minore de
                {
                    Console.WriteLine("Ha vinto Milan");//scrive a schermo "Ha vino Milan"
                }
                else if(Juventus.Punti() == Milan.Punti())
                {
                    Console.WriteLine("Hanno pareggiato");//scrive a schermo "Ha vino Milan"
                }
                else
                {
                    Console.WriteLine("Ha vinto la Juventus");//scrive a schermo "Ha vino Milan"
                }
                Juventus.IncrementoPunteggio();
                Milan.IncrementoPunteggio();
                Juventus.InizioAnno();
                Milan.InizioAnno();
                answer = "";
                Console.WriteLine("Scrivi yes o y per terminare il campionato");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "y");
            if(Juventus.ReturnPunteggioTotale() < Milan.ReturnPunteggioTotale())
            {
                Console.WriteLine($"Il vincitore del campionato e' Milan con {Milan.ReturnPunteggioTotale()} punti");
            }
            else if(Juventus.ReturnPunteggioTotale() == Milan.ReturnPunteggioTotale())
            {
                Console.WriteLine($"Il campionato è terminato in un pareggio");
            }
            else
            {
                Console.WriteLine($"Il vincitore del campionato e' Juventus con {Juventus.ReturnPunteggioTotale()} punti");
            }*/
        }
    }
}
