using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InteresSimple : Intereses
    {
        public double CalcularInteresCompuesto()
        {
            return 0;
        }

        public string CalcularInteresSimple()
        {
            if (dias != 0 && meses != 0 && años != 0)
            {
                if (CapitalInicial != 0 && Interes != 0)
                {
                    //Aqui Se Calcula La Tasa de Interes Por Dias,Meses y Años.
                    return CalcularTasaDeInteres();
                }
                if (CapitalInicial != 0 && TasaDeInteres != 0)
                {
                    //Aqui Se Calcula El Interes Por dia, Meses , Años.
                    return CalcularInteres();
                }
                if (Interes != 0 && TasaDeInteres != 0)
                {
                    //Aqui Se Calcula El Capital Inicial Por dias,meses,años.
                    return CalcularCapitalInicial();
                }
                return "Error";
                //final dias meses años
            }
            else
            {
                //Inicio Dias Mese
                if (dias != 0 && meses != 0)
                {
                    //falta
                    if (CapitalInicial != 0 && TasaDeInteres != 0)
                    {
                        //Interes
                        return CalcularInteres();
                    }
                    if(CapitalInicial != 0 && Interes != 0)
                    {
                        //Tasa de Interes
                        return CalcularTasaDeInteres();
                    }
                    if (Interes != 0 && TasaDeInteres != 0)
                    {
                        //Capital Inicial
                        return CalcularCapitalInicial();
                    }
                    return "Error";
                }
                else
                {
                    //Inicio dias Años
                    if (dias != 0 && años != 0)
                    {
                        if (CapitalInicial != 0 && TasaDeInteres != 0)
                        {
                            //Interes
                            return CalcularInteres();
                        }
                        if (CapitalInicial != 0 && Interes != 0)
                        {
                            //Tasa de Interes
                            return CalcularTasaDeInteres();
                        }
                        if (Interes != 0 && TasaDeInteres != 0)
                        {
                            //Capital Inicial
                            return CalcularCapitalInicial();
                        }
                        return "Error";
                    }
                    else
                    {
                        //Inicio Años Meses
                        if(años != 0 && meses != 0)
                        {
                            if (CapitalInicial != 0 && TasaDeInteres != 0)
                            {
                                //Interes
                                return CalcularInteres();
                            }
                            if (CapitalInicial != 0 && Interes != 0)
                            {
                                //Tasa de Interes
                                return CalcularTasaDeInteres();
                            }
                            if (Interes != 0 && TasaDeInteres != 0)
                            {
                                //Capital Inicial
                                return CalcularCapitalInicial();
                            }
                            return "Error Setor Años y Meses";
                        }
                        else
                        {
                            //Inicios Dias
                            if(dias != 0)
                            {
                                if (CapitalInicial != 0 && TasaDeInteres != 0)
                                {
                                    //Interes
                                    return CalcularInteres();
                                }
                                if (CapitalInicial != 0 && Interes != 0)
                                {
                                    //Tasa de Interes
                                    return CalcularTasaDeInteres();
                                }
                                if (Interes != 0 && TasaDeInteres != 0)
                                {
                                    //Capital Inicial
                                    return CalcularCapitalInicial();
                                }
                                return "Error Sector dias";
                            }
                            else
                            {
                                //Inicio Meses
                                if(meses != 0)
                                {

                                    if (CapitalInicial != 0 && TasaDeInteres != 0)
                                    {
                                        //Interes
                                        return CalcularInteres();
                                    }
                                    if (CapitalInicial != 0 && Interes != 0)
                                    {
                                        //Tasa de Interes
                                        return CalcularTasaDeInteres();
                                    }
                                    if (Interes != 0 && TasaDeInteres != 0)
                                    {
                                        //Capital Inicial
                                        return CalcularCapitalInicial();
                                    }
                                    return "Error Sector meses";
                                }
                                else
                                {
                                    //Inicio de Años
                                    if (años != 0)
                                    {
                                        if (CapitalInicial != 0 && TasaDeInteres != 0)
                                        {
                                            //Interes
                                            return CalcularInteres();
                                        }
                                        if (CapitalInicial != 0 && Interes != 0)
                                        {
                                            //Tasa de Interes
                                            return CalcularTasaDeInteres();
                                        }
                                        if (Interes != 0 && TasaDeInteres != 0)
                                        {
                                            //Capital Inicial
                                            return CalcularCapitalInicial();
                                        }
                                        return "Error";
                                    }
                                    else
                                    {
                                        if ((Interes == 0 || CapitalInicial == 0) || (Interes == 0 || TasaDeInteres == 0) || (CapitalInicial == 0 || TasaDeInteres == 0))
                                        {
                                            return "No se Puede Calcular el Tiempo por Favor llene los campos";
                                        }
                                        else
                                        {
                                            return CalcularTiempo();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private string CalcularTasaDeInteres()//Calculo General De Tasa de Interes
        {
            float i = (float)(Interes / (CapitalInicial * (años + (meses / 12) + (dias / 365)))) * 100;
            return "La Tasa De Interes Es De: " + i + " %";
        }
        private string CalcularCapitalInicial()//Metodo General de Capital Inicial
        {
            float p = (Interes / ((TasaDeInteres / 100) * ConversionPorDias()));
            return " El Capital Inicial es De: " + p;
            //return ConversionPorDias().ToString();
        }

        private string CalcularInteres()//Metodo General de Interes
        {
            float i = (CapitalInicial * (TasaDeInteres / 100) * (años + (meses / 12) + (dias / 360)));
            return "El Interes es De: " + i;
        }

        private float ConversionPorDias()
        {
            float t = 0;
            //t = años + (((meses * 30) + (dias / 30)) / 365);
            t = años + ((meses * 30) / 360) + (dias / 360);
            return t;
        }

        private string CalcularTiempo()
        {
            float time = Interes / (CapitalInicial * (TasaDeInteres / 100));
            float aux = ((time - 1) * 360) / 30;
            int anos = (int)time;
            int mes = (int)(aux);
            int dia = (int)(((aux) - mes) * 30);
            return anos + " Año " + mes + " Meses " + dia + " Dias";
        }
    }
}
