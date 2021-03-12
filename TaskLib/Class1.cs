using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLib
{
    public class Class1
    {
        /// <summary>
        /// Проверка проходимости кирпича через отверстие
        /// </summary>
        /// <param name="longRectangle"> Длина кирпича</param>
        /// <param name="widthRectangle">Ширина кирпича</param>
        /// <param name="heightRectangle">Высота кирпича</param>
        /// <param name="longPort">Длина отверстия</param>
        /// <param name="widthPort">Ширина отверстия</param>
        /// <returns></returns>
        public bool Check(int longRectangle, int widthRectangle, int heightRectangle, int longPort, int widthPort)
        {
            //int s_otv = longPort * widthPort;
            if ((longPort == longRectangle && widthPort == widthRectangle) || (widthRectangle == longPort && longRectangle == widthPort) 
                || (longPort == widthRectangle && widthPort == heightRectangle) || (longPort == heightRectangle && widthPort == longRectangle) || (longPort == heightRectangle && widthPort  == widthRectangle) || (longPort == longRectangle && widthPort == heightRectangle))
            {
                return true;
            }
            else return false;




        }

    }
}
