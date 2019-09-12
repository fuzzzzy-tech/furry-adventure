using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzeRPG.Common.Entities
{
    internal interface IActor
    {
        double Health { get; set; }
        double Stamina { get; set; }
        double Mana { get; set; }

        IContainer Inventory { get; }

        void Equip(IEquipment equipment);

        void Unequip(IEquipment equipment);

        void Fight(IActor target);

        void Consume(IConsumable consumable);
    }
}
