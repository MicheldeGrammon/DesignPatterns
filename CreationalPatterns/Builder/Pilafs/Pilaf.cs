using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pilafs
{
    internal class Pilaf
    {
        public Meat Meat { get; set; }
        public Carrot Carrot { get; set; }
        public Rice Rice { get; set; }

        public string GetPilaf()
        {
            var sb = new StringBuilder();

            sb.Append("Плов: ");

            if (Rice != null)
                sb.Append(Rice.Sort);
            else
                throw new Exception("Плов без риса? Ты точно ошпаз?");

            if (Carrot != null)
                sb.Append(" + Морковь(любая)");

            if (Meat != null)
                sb.Append(" + " + Meat.Type);

            return sb.ToString();
        }
    }
}
