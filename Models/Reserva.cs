namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            try { 
                
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                   throw new Exception("ATENÇÃO: Capacidade é menor que a quantidade de hóspede!!"); 
                }
            
            }
            catch(Exception ex)
            {
                    Console.WriteLine($"{ex.Message}");            
            }
        
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
        
        int qntdHospede = 0; 
           for(int i = 0; i < Hospedes.Count; i++)
                    qntdHospede++; 

            return qntdHospede;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if(DiasReservados >= 10) 
                        valor = valor * 0.9M; //Variação Percentual = valorOriginal * (1 - 0.10) **  
          
            return valor;
        }
    
        }
    }
