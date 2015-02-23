namespace Trulon.Interfaces
{
    public interface IItem
    {
        int SpeedPointsBuff { get; set; }

        int DefensePointsBuff { get; set; }

        int AttackPointsBuff { get; set; }

        int HealthPointsBuff { get; set; }

        int AttackRadiusBuff { get; set; }

        int Price { get; set; }
    }
}
