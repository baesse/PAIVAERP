using Word= Microsoft.Office.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ConfigClasses
{
    

    class ManipulaWord
    {
       

        public void PreencherPorReplace(string CaminhoModelo,ClassesPrograma.Pessoa pessoa,ClassesPrograma.PTSocietaria[] SOCIEDADE,ClassesPrograma.Fatorelevante FATOS)
        {
            object missing = System.Reflection.Missing.Value;

            Word.Word.Application oApp = new Word.Word.Application();

            object template = CaminhoModelo;

            Word.Word.Document odoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            Word.Word.Range oRng = odoc.Range(ref missing, ref missing);




            //PREENCHER DADOS DO PESQUISADO
            object FindTextnome = "@nomecliente";
            object ReplaceWithNome = pessoa.nome;
            object MatchWholeWordnome = true;
            object Forward = false;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);


            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@endereco";
            ReplaceWithNome = pessoa.endereco;           
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
          



            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@email";
            ReplaceWithNome = pessoa.email;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
           


            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@telefone";
            ReplaceWithNome = pessoa.contatoTelefonico;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
          

            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@celular";
            ReplaceWithNome = pessoa.celular;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
          

            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@naturalidade";
            ReplaceWithNome = pessoa.naturalidade;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
           



            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@cpf";
            ReplaceWithNome = pessoa.cpfnCnpjpessoa;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
         
            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@identidade";
            ReplaceWithNome = pessoa.ci;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
          

            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@tituloeleitor";
            ReplaceWithNome = pessoa.titulodeeleitor;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
          

            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@nomepai";
            ReplaceWithNome = pessoa.nomepai;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
           



            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@nomemae";
            ReplaceWithNome = pessoa.nomemae;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
            

            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@data";
            ReplaceWithNome =DateTime.Today;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
            //FIM DADOS DO PESQUISADO




















            ////PREENCHER DADOS PTSOCIETARIA
            int i = 0;
            while (i < SOCIEDADE.Length)
            {


                StringBuilder PTSOCIETARIA = new StringBuilder();
                PTSOCIETARIA.Append(". inscrição CNPJ     " + SOCIEDADE[0].cnpj);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria1";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);




                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". data de fundação     " + SOCIEDADE[0].datafundacao);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria2";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);





                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". % sobre o capital     " + SOCIEDADE[0].participacaocapital);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria3";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);



                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". capital social     " + SOCIEDADE[0].capitalsocial);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria4";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);




                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". empresa     " + SOCIEDADE[0].nomemepresa);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria5";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);





                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". endereço     " + SOCIEDADE[0].endereco);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria5";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);




                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". receita federal     " + SOCIEDADE[0].receitafederal);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("\n");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria6";
                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);




                PTSOCIETARIA.Clear();
                PTSOCIETARIA.Append(". receita estadual     " + SOCIEDADE[0].receitaestadual);
                PTSOCIETARIA.Append("\n");
                PTSOCIETARIA.Append("^p");
                oRng = odoc.Range(ref missing, ref missing);
                FindTextnome = "@ptsocietaria7";

            



                ReplaceWithNome = PTSOCIETARIA.ToString();
                oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
                oApp.Visible = true;



               

                if (PTSOCIETARIA.Length > 1)
                {
                   
                   
                    FindTextnome = "@proxima";
                    for (int j = 1; j <8; j++)
                    {
                       
                         
                            
                        
                        oRng = odoc.Range(ref missing, ref missing);

                        oRng.Font.Bold = 7;
                        oRng.Font.Name = "Calibri";
                        oRng.Font.Size = 7.5F;
                        ReplaceWithNome = "@ptsocietaria" + j + "^p"+ " @ptsocietaria" + j + 1;                        
                        oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);
                        FindTextnome = "@ptsocietaria" + j+1;
                        
                    }

                }

                i++;
            }



            // FIM PARTICIPAÇÃO SOCIETARIA






            
            //FATOS RELEVANTES 
            oRng = odoc.Range(ref missing, ref missing);
            FindTextnome = "@fatos";
            ReplaceWithNome = FATOS.descricao;
            oRng.Find.Execute(ref FindTextnome, ref missing, ref MatchWholeWordnome, ref missing, ref missing, ref missing, ref Forward, ref missing, ref missing, ref ReplaceWithNome, ref missing, ref missing, ref missing, ref missing, ref missing);



        }
    }
}
