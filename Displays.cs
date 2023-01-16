using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lasertower
{
    internal class Displays
    {
        public class Base : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-000", mod);
            }
        }
        public class Tier1 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-010", mod);
            }
        }
        public class Tier2 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-020", mod);
            }
        }
        public class Tier3 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-030", mod);
            }
        }
        public class Tier4 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-040", mod);
            }
        }
        public class Tier5 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                helper.LaserTowerNode(node, "lasertower-050", mod);
            }
        }
        public class Projectile : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.rotation = Quaternion.identity;
                node.GetRenderer<SpriteRenderer>().sprite = null;
                var prefab = helper.LoadAsset<GameObject>("projectile", GetBundle("lasertowerbundle"));
                var projectileObject = UnityEngine.Object.Instantiate(prefab, node.transform.GetChild(0).transform);
            }
        }
        public class Projectile2 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.rotation = Quaternion.identity;
                node.GetRenderer<SpriteRenderer>().sprite = null;
                var prefab = helper.LoadAsset<GameObject>("projectile2", GetBundle("lasertowerbundle"));
                var projectileObject = UnityEngine.Object.Instantiate(prefab, node.transform.GetChild(0).transform);
            }
        }
        public class Projectile3 : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;
            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                node.transform.rotation = Quaternion.identity;
                node.GetRenderer<SpriteRenderer>().sprite = null;
                var prefab = helper.LoadAsset<GameObject>("projectile3", GetBundle("lasertowerbundle"));
                var projectileObject = UnityEngine.Object.Instantiate(prefab, node.transform.GetChild(0).transform);
            }
        }
    }
}
