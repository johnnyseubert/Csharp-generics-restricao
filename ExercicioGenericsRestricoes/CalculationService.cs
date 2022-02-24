using System;
using System.Collections.Generic;

namespace ExercicioGenericsRestricoes
{
    public class CalculationService
    {
        // a letar G diz que é generico eu posso passar oq eu quiser
        // e só aceita tipos que podem ser comparados pelo Icomparable, string number etc
        public G Max<G>(List<G> list) where G : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }
            G max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}