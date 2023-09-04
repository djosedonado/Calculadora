using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Calcular : Intereses
    {

        public double CalcularInteresSimple() 
        {
            if (dias != 0 && meses != 0 && años != 0)
            {
                if (ValorInicial != 0 && ValorFinal != 0)
                {
                    return CalcularDiasMesesAños();
                }
                return Resultado = 1;
            }
            else
            {
                if (dias != 0 && meses != 0)
                {
                    return Resultado = 2;
                }
                else
                {
                    if (dias != 0 && años != 0)
                    {
                        return Resultado = 3;
                    }
                    else
                    {
                        if(años != 0 && meses != 0)
                        {
                            if(interes != 0 && ValorInicial != 0 && ValorFinal == 0)
                            {
                                return calcularValorFuturoPorAñosYMeses();
                            }
                            else
                            {
                                if (interes != 0 && ValorInicial == 0 && ValorFinal != 0)
                                {
                                    return calcularValorPresentePorMeseYAños();
                                }
                                else
                                {
                                    if (interes == 0 && ValorInicial != 0 && ValorFinal != 0)
                                    {
                                        return calcularInteresPorAñosYMeses();
                                    }
                                }
                            }
                            return Resultado = 4;
                        }
                        else
                        {
                            if(dias != 0)
                            {
                                return Resultado = 5;
                            }
                            else
                            {
                                if(meses != 0)
                                {
                                    if (meses != 0 && interes != 0 && ValorInicial != 0 && ValorFinal == 0)
                                    {
                                        return calcularValorFuturo();
                                    }
                                    else
                                    {
                                        if(meses != 0 && interes != 0 && ValorInicial == 0 && ValorFinal != 0)
                                        {
                                           return calcularValorPresente();
                                        }
                                        else
                                        {
                                            if (meses != 0 && interes == 0 && ValorInicial != 0 && ValorFinal != 0)
                                            {
                                                return calcularInteres();
                                            }
                                        }
                                    }
                                    return 0;
                                }
                                else
                                {
                                    if (años != 0)
                                    {
                                        if (ValorInicial != 0 && interes != 0)
                                        {
                                            return interesPorAños();
                                        }
                                        return Resultado = 7;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return calcularTiempo();
        }

        private double calcularValorFuturoPorAñosYMeses()
        {
            return ValorInicial * (1 + (interes / 100) * ((12 * años) + meses));
        }

        private double CalcularDiasMesesAños()
        {
            double valor = (365 * años) + (30 * meses) + dias;
            double valor2 = (ValorFinal - ValorInicial);
            return (valor2 / (ValorInicial * valor)) * 365 * 100;
        }

        private double interesPorAños()
        {
            return ValorInicial * años * (interes/100);
        }

        private double calcularValorFuturo()
        {
            return ValorInicial * (1 + (interes / 100) * meses);
        }

        private double calcularValorPresente()
        {
            return ValorFinal / (1 + meses * (interes / 100));
        }
        private double calcularValorPresentePorMeseYAños()
        {
            return ValorFinal / (1 + (meses + (12 * años)) * (interes / 100));
        }
        private double calcularInteres()
        {
            return ((1 / meses) * ((ValorFinal / ValorInicial) - 1)) * 100;
        }
        private double calcularInteresPorAñosYMeses()
        {
            return ((1 / (meses + (años * 12))) * ((ValorFinal / ValorInicial) - 1)) * 100;
        }
        private double calcularTiempo()
        {
            return 1 / (interes / 100) * ((ValorFinal / ValorInicial) - 1);
        }
    }
}
