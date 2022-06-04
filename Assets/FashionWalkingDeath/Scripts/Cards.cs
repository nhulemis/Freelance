using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    [CreateAssetMenu(fileName = "new item card", menuName = "item")]
    public class Cards : ScriptableObject
    {
        public string concepttemName;
        public int levelIndex;
        public Sprite[] tshirtItemsAvatar;
        public Sprite[] shoesItemsAvatar;
        public Sprite[] skirtItemsAvatar;
        public Sprite[] hairItemsAvatar;
        public Sprite[] pontalonItemsAvatar;
        public Sprite[] GlassesItemsAvatar;
        public Sprite[] necklasesItemsAvatar;
        public Sprite[] glovesItemsAvatar;
        public int[] items;

        public Sprite[] retriveTshirtItems()
        {
            return tshirtItemsAvatar;
        }
        public Sprite[] retriveshoesItems()
        {
            return shoesItemsAvatar;
        }
        public Sprite[] retriveSkirtItems()
        {
            return skirtItemsAvatar;
        }
        public Sprite[] retriveHairItems()
        {
            return hairItemsAvatar;
        }
        public Sprite[] retrivePontalonItems()
        {
            return pontalonItemsAvatar;
        }
        public Sprite[] retriveGlassesItems()
        {
            return GlassesItemsAvatar;
        }
        public Sprite[] retriveneckLessItems()
        {
            return necklasesItemsAvatar;
        }
        public Sprite[] retriveGloves()
        {
            return glovesItemsAvatar;
        }


        public int[] item()
        {
            return items;
        }

    }
}
