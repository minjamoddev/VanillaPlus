using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenLib.References;

namespace KitchenVanillaPlus.Mains
{
    class LettuceBurgerCard : CustomDish
    {
        public override string UniqueNameID => "Burger - Lettuce";
        public override DishType Type => DishType.Extra;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsSpecificFranchiseTier => false;
        public override bool DestroyAfterModUninstall => false;
        public override bool IsUnlockable => true;

        public override List<Unlock> HardcodedRequirements => new()
        {
            (Dish)GDOUtils.GetExistingGDO(DishReferences.BurgerBase)
        };
        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            (Item)GDOUtils.GetExistingGDO(ItemReferences.Lettuce)
        };
        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook)
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            { Locale.English, "Add chopped lettuce to burgers" }
        };
        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
            (Locale.English, LocalisationUtils.CreateUnlockInfo("Sloppy Steaks", "It's a steak with water dumped on it, it's really really good", "Let's slop 'em up!"))
        };
    }
}