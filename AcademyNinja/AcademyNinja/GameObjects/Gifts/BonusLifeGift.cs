namespace AcademyNinja.GameObjects.Gifts
{
    using AcademyNinja.Contracts;

    internal class BonusLifeGift : IGift
    {
        private const byte BonusLife = 1;

        public void Apply(INinja ninja)
        {
            ninja.Lives += BonusLife;
        }
    }
}
