using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lasertower;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

namespace lasertower
{
    internal class lasertower
    {
        public class MrBeast : ModTower
        {
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Base>();
                var attackModel = towerModel.GetAttackModel();
                var projectileModel = attackModel.weapons[0].projectile;
                projectileModel.ApplyDisplay<Displays.Projectile>();
                towerModel.range = 50f;
                attackModel.range = towerModel.range;
                attackModel.weapons[0].projectile.pierce = 5f;
                attackModel.weapons[0].projectile.GetDamageModel().damage = 3f;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Lead;
            }



            public override string Icon => "Icon";
            public override string Portrait => "Icon";

            public override string Name => "Laser Tower";
            public override string DisplayName => "Laser Tower";
            public override TowerSet TowerSet => TowerSet.Magic;
            public override string BaseTower => TowerType.DartMonkey;
            public override int Cost => 1000;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 5;
            public override int BottomPathUpgrades => 0;


        }
        public class Tier1 : ModUpgrade<MrBeast>
        {
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Tier1>();
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].projectile.GetDamageModel().damage *= 2;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Lead;
            }

            public override string Name => "More Power";
            public override string Description => "Damage doubled.";
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override int Cost => 400;

            public override string Icon => "morepower";
        }
        public class Tier2 : ModUpgrade<MrBeast>
        {
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Tier2>();
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].rate = 0.4f;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Lead;
            }

            public override string Name => "Faster Lasers";
            public override string Description => "The tower shoots faster.";
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override int Cost => 1000;

            public override string Icon => "faster";
        }
        public class Tier3 : ModUpgrade<MrBeast>
        {
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Tier3>();
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].rate = 0.3f;
                attackModel.weapons[0].projectile.GetDamageModel().damage *= 3;
                attackModel.weapons[0].projectile.pierce += 5f;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Lead;
            }

            public override string Name => "Full Laser Power";
            public override string Description => "Gains Full Power Of The Lasers.";
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override int Cost => 5000;

            public override string Icon => "full";
        }
        public class Tier4 : ModUpgrade<MrBeast>
        {
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Tier4>();
                towerModel.range += 20f;
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].rate = 0.25f;
                attackModel.weapons[0].projectile.pierce += 2f;
                attackModel.range = towerModel.range;
                var ice = Game.instance.model.GetTowerFromId("IceMonkey-400").GetAttackModel().Duplicate();
                ice.weapons[0].rate = attackModel.weapons[0].rate;
                ice.range = attackModel.range;
                ice.weapons[0].projectile.radius = attackModel.range;
                attackModel.AddBehavior(ice);
                towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
                towerModel.GetWeapon().projectile.ApplyDisplay<Displays.Projectile2>();
            }

            public override string Name => "Icy Lasers";
            public override string Description => "Bursts ice to freeze bloons.";
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override int Cost => 7000;

            public override string Icon => "Icy";
        }
        public class Tier5 : ModUpgrade<MrBeast>
        {
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<Displays.Tier5>();
                towerModel.range += 50f;
                var attackModel = towerModel.GetAttackModel();
                attackModel.range = towerModel.range;
                attackModel.weapons[0].rate = 0f;
                var explosion = Game.instance.model.GetTowerFromId("BombShooter-500").GetAttackModel().Duplicate();
                explosion.range = attackModel.range;
                explosion.weapons[0].rate = 0f;
                explosion.weapons[0].projectile.scale = 0f;
                attackModel.AddBehavior(explosion);
                towerModel.GetWeapon().projectile.ApplyDisplay<Displays.Projectile3>();
            }

            public override string Name => "Uranium Lasers";
            public override string Description => "Explosions.";
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override int Cost => 50000;

            public override string Icon => "uranium";
        }
    }
}