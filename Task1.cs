using System;

namespace Test1
{
    public struct Damage
    {
        public float Value;
        public int Type;

        public Damage(float value, int type)
        {
            Value = value;
            Type = type;
        }
    }

    public interface IWeapon
    {
        Damage GetAttackDamage();
    }
    
    public class Sword : IWeapon
    {
        private Damage _damage;
        
        public Sword(float damage, int damageType)
        {
            _damage.Value = damage;
            _damage.Type = damageType;
        }
        
        public Damage GetAttackDamage() => _damage;
    }
    /// <summary>
    /// в данном случае можно реализовать огненный и ледяной мечь подставляя в поле _damage разные значения
    /// или, если требуется координально разное поведения, можно создать новый классы на основе IWeapon.
    /// задачу прокачки меча будет реализовывать сервис IWeaponUpdater реализация его зависит от того каким именно образом можно прокачивать мечь (покупка или сложение например)
    /// </summary>
    
}
