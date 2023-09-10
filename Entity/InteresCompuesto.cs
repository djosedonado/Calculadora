using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InteresCompuesto : Intereses
    {
        public string interesCompuesto()
        {
            if (años != 0 && meses != 0 && dias != 0)
            {
                return "";//respuesta
            }
            else
            {
                if ((años != 0 && meses != 0) || (años != 0 && dias != 0) || (dias != 0 && meses != 0))
                {
                    return "";
                }
                else
                {
                    if (dias != 0)
                    {
                        return "";

                    }
                    else
                    {
                        if(meses != 0)
                        {
                            return "";
                        }
                        else
                        {
                            if(años != 0)
                            {
                                return "";
                            }
                            else
                            {
                                if (Trimestral != 0)
                                {
                                    return "";
                                }
                                else
                                {
                                    if (Cuatrimestral != 0)
                                    {
                                        return "";
                                    }
                                    else
                                    {
                                        if(Semestral != 0)
                                        {
                                            return "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return "Hola Jovenazo";
        }
        private string CalcularInteres()
        {
            return "";
        }
    }
}
