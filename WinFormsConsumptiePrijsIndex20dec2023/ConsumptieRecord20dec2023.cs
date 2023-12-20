using System.Globalization;

namespace WinFormsConsumptiePrijsIndex20dec2023
{
    internal class ConsumptieRecord20dec2023
    {
        public string StringJaar { private get; set; }

        public int Jaar
        {
            get
            {
                int result = Convert.ToInt32(StringJaar);
                return result;
            }
        }

        public string StringMaand { private get; set; }

        public int Maand
        {
            get
            {
                int result = Convert.ToInt32(StringMaand);
                return result;
            }
        }

        /// <summary>
        /// is overal ingevuld
        /// </summary>
        public string StringConsumptieprijsindex { private get; set; }

        public double Consumptieprijsindex
        {
            get
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                double result = Convert.ToDouble(StringConsumptieprijsindex, provider);
                return result;
            }
        }

        /// <summary>
        /// is ingevuld vanaf 2006
        /// </summary>
        public string String_Index_zonder_energetische_producten { get; set; }

        public double Index_zonder_energetische_producten
        {
            get
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                double result = Convert.ToDouble(String_Index_zonder_energetische_producten, provider);
                return result;
            }
        }


        /// <summary>
        /// is ingevuld vanaf 1997
        /// </summary>
        public string String_Index_zonder_petroleum_producten { get; set; }

        public double Index_zonder_petroleum_producten
        {
            get
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                double result = Convert.ToDouble(String_Index_zonder_petroleum_producten, provider);
                return result;
            }
        }


        public string StringWeging { private get; set; }

        public int Weging
        {
            get
            {
                int result = Convert.ToInt32(StringWeging);
                return result;
            }
        }


        public string StringInflatie { get; set; }

        public double Inflatie
        {
            get
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                double result = Convert.ToDouble(StringInflatie, provider);
                return result;
            }
        }

        /// <summary>
        /// is ingevuld vanaf 1994
        /// </summary>
        public string StringGezondheidsindex { get; set; }


        public double Gezondheidsindex
        {
            get
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                double result = Convert.ToDouble(StringGezondheidsindex, provider);
                return result;
            }
        }


        public string String_Afgevlakte_gezondheidsindex { get; set; }

        public string StringBasisjaar { get; set; }

        public int Basisjaar
        {
            get
            {
                int result = Convert.ToInt32(StringBasisjaar);
                return result;
            }
        }
    }
}

