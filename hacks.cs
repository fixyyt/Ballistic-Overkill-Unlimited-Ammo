using UnityEngine;

namespace Loader.cs
{
    internal class hacks : MonoBehaviour
    {
        
        public void Update()
        {
            ShootController Ammo = FindObjectOfType<ShootController>();
            
            Ammo.MagazineRemainingAmmo = 85;
            

            if(Input.GetKeyUp(KeyCode.Delete))
            {
                Loader.Unload();
            }
        }
    }
}
