using Andaluh;
using Xunit;

namespace Tests
{
    public class Unit
    {
        [Fact]
        public void LLCambiaY()
        {
            var res = EPA.Transcribe("LL ll");

            Assert.Equal("Y y", res);
        }

        [Fact]
        public void CHCambiaX()
        {
            var res = EPA.Transcribe("CH ch Chan chan");

            Assert.Equal("X x Xan xan", res);
        }

        [Fact]
        public void Entendederas()
        {
            var res = EPA.Transcribe("absolvederas entendederas");

            Assert.Equal("���orbe�r� entende�r�", res);
        }

        [Fact]
        public void Alhurreca()
        {
            var res = EPA.Transcribe("alhurreca");

            Assert.Equal("alhurreca", res);
        }

        [Fact]
        public void Ahuehue()
        {
            var res = EPA.Transcribe("ahuehu�");

            Assert.Equal("aguegu�", res);
        }

        [Fact]
        public void ElQueAcanala()
        {
            var res = EPA.Transcribe("acanalador");

            Assert.Equal("acanala�h", res);
        }
        
        [Fact]
        public void D_Intervocalica()
        {
            var res = EPA.Transcribe("Oido un ruido");

            Assert.Equal("O�o un ru�o", res);
        }

        [Fact]
        public void HaberA_ver()
        {
            var res = EPA.Transcribe("A ver [haber]");

            Assert.Equal("A b�h [ab�h]", res);
        }

        [Fact]
        public void Envidia()
        {
            var res = EPA.Transcribe("ENVIDIA");

            Assert.Equal("EMBIDIA", res);
        }

        [Fact]
        public void Around()
        {
            var res = EPA.Transcribe("Alrededor");

            Assert.Equal("Arreded�h", res);
        }

        [Fact]
        public void Acetamida()
        {
            var res = EPA.Transcribe("acetamida");

            Assert.Equal("a�etamida", res);
        }

        [Fact]
        public void Aljarafe()
        {
            var res = EPA.Transcribe("aljarafe alg�brico");

            Assert.Equal("arharafe arh�brico", res);
        }

        [Fact]
        public void El()
        {
            var res = EPA.Transcribe("el agua, el Manuel, el agua del Manuel");

            Assert.Equal("el agua, er Manu�h, el agua der Manu�h", res);
        }

        [Fact]
        public void AFortiori()
        {
            var res = EPA.Transcribe("a fortiori");

            Assert.Equal("afortiori", res);
        }

        [Fact]
        public void Apegaderas()
        {
            var res = EPA.Transcribe("apegaderas");

            Assert.Equal("apega�r�", res);
        }

        [Fact]
        public void Del()
        {
            var res = EPA.Transcribe("del abstracto");

            Assert.Equal("del �ttr�tto", res);
        }
        [Fact]
        public void Desposeido()
        {
            var res = EPA.Transcribe("despose�do");

            Assert.Equal("d�ppo�e�o", res);
        }
        

        [Fact]
        public void Dulce()
        {
            var res = EPA.Transcribe("alm�bar");

            Assert.Equal("arm�b�", res);
        }

        [Fact]
        public void Tonto()
        {
            var res = EPA.Transcribe("est�pido");

            Assert.Equal("�tt�pido", res);
        }

        [Fact]
        public void Manuel()
        {
            var res = EPA.Transcribe("el Manuel");

            Assert.Equal("er Manu�h", res);
        }

        [Fact]
        public void Nicolas()
        {
            var res = EPA.Transcribe("maduro");

            Assert.Equal("ma�ro", res);
        }

        [Fact]
        public void Escuchar()
        {
            var res = EPA.Transcribe("o�r");

            Assert.Equal("o�h", res);
        }

        [Fact]
        public void Silvar()
        {
            var res = EPA.Transcribe("sILBAR");

            Assert.Equal("�IRB�H", res);
        }

        [Fact]
        public void Traslado()
        {
            var res = EPA.Transcribe("translados");

            Assert.Equal("tr�l-l��", res);
        }

        [Fact]
        public void Triceps()
        {
            var res = EPA.Transcribe("tr�ceps");

            Assert.Equal("tr���", res);
        }

        [Fact]
        public void Bebedero()
        {
            var res = EPA.Transcribe("aljibe aljuba");

            Assert.Equal("arhibe arhuba", res);
        }
        

        [Fact]
        public void Cai()
        {
            var res = EPA.Transcribe("C�diz");

            Assert.Equal("C�d�", res);
        }

        [Fact]
        public void Transportandonos()
        {
            var res = EPA.Transcribe("Transportandonos a la connotaci�n perspicaz del abstracto solsticio de Alaska, el aislante pl�stico adsorvente asfixi�");

            Assert.Equal("Tr�pportandon� a la c�nnota�i�n perppic�h del �ttr�tto �ortti�io de Al�kka, el a�l-lante pl�ttico ���orbente �ff���i�", res);
        }

        
        [Fact]
        public void Absorvente()
        {
            var res = EPA.Transcribe("adsorvente absorvente");

            Assert.Equal("���orbente ���orbente", res);
        }
       

        [Fact]
        public void Sexy()
        {
            var res = EPA.Transcribe("sexy");

            Assert.Equal("����y", res);
        }

        [Fact]
        public void Cacahue()
        {
            var res = EPA.Transcribe("cacaHuETes");

            Assert.Equal("cacaGuET�", res);
        }

        [Fact]
        public void Cicahue()
        {
            var res = EPA.Transcribe("cicahuite");

            Assert.Equal("�icaguite", res);
        }

        [Fact]
        public void Spanglish()
        {
            var res = EPA.Transcribe("ESPANGLISH");

            Assert.Equal("�PPANGL�", res);
        }

        [Fact]
        public void Escapes()
        {
            var res = EPA.Transcribe("@miguel http://google.com #Hashtag");

            Assert.Equal("@miguel http://google.com #Hashtag", res);
        }

        [Fact]
        public void MasEscapes()
        {
            var res = EPA.Transcribe("Mi correo es todito@outlook.com es de Outlook. Tambi�n tengo cuenta en twitter");

            Assert.Equal("Mi correo � todito@outlook.com � de Outlook. Tambi�n tengo cuenta en twitter", res);
        }

        [Fact]
        public void Casada()
        {
            var res = EPA.Transcribe("Casada");

            Assert.Equal("Ca��", res);
        }

        [Fact]
        public void Cazabombardero()
        {
            var res = EPA.Transcribe("cazabombardero");

            Assert.Equal("ca�abombardero", res);
        }

        [Fact]
        public void Cual()
        {
            var res = EPA.Transcribe("cual");

            Assert.Equal("cu�h", res);
        }

        [Fact]
        public void Acar()
        {
            var res = EPA.Transcribe("ahotado");

            Assert.Equal("ahotao", res);
        }
        

        [Fact]
        public void Pseudoescritor()
        {
            var res = EPA.Transcribe("pseudoescritor");

            Assert.Equal("�eudo�ccrit�h", res);
        }

        [Fact]
        public void Extasis()
        {
            var res = EPA.Transcribe("�xtasis");

            Assert.Equal("�tta��", res);
        }

        [Fact]
        public void Asfixian()
        {
            var res = EPA.Transcribe("asfixian");

            Assert.Equal("�ff���ian", res);
        }

        [Fact]
        public void AbdicanAsfixian()
        {
            var res = EPA.Transcribe("asfixian y �xtasis");

            Assert.Equal("�ff���ian y �tta��", res);
        }

        [Fact]
        public void ExtasisAsfixian()
        {
            var res = EPA.Transcribe("�xtasis y asfixian");

            Assert.Equal("�tta�� y �ff���ian", res);
        }

        [Fact]
        public void Saxo()
        {
            var res = EPA.Transcribe("saxof�n");

            Assert.Equal("����of�n", res);
        }

        [Fact]
        public void Valkiria()
        {
            var res = EPA.Transcribe("valkirias");

            Assert.Equal("barkiri�", res);
        }

        [Fact]
        public void Viandero()
        {
            var res = EPA.Transcribe("viandero");

            Assert.Equal("biandero", res);
        }

        [Fact]
        public void Bueno()
        {
            var res = EPA.Transcribe("Qu� Bueno, qu� buena");

            Assert.Equal("Qu� Gueno, qu� guena", res);
        }

        [Fact]
        public void Coger()
        {
            var res = EPA.Transcribe("aprehender");

            Assert.Equal("aprehend�h", res);
        }

        [Fact]
        public void TodasLasCosas()
        {
            var res = EPA.Transcribe("Todo Todito todo");

            Assert.Equal("T� Toito t�", res);
        }

        [Fact]
        public void QuieroAgua()
        {
            var res = EPA.Transcribe("Tengo sed. Sed!");

            Assert.Equal("Tengo ��h. ��h!", res);
        }
    }
}
