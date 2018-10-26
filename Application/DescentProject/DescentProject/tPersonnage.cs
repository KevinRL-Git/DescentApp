using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescentProject
{
    class tPersonnage
    {
        private string pName = "";
        private string pClasse = "";
        //Characteristics
        private int pHealth = 0;
        private int pStamina = 0;
        private int pSpeed = 0;
        private string pDefense = "";
        //Hero Ability
        private string pAbility = "";
        private string pHeroicFeat = "";
        //Attributes
        private int pMight = 0;
        private int pKnowledge = 0;
        private int pWillpower = 0;
        private int pAwareness = 0;

        public tPersonnage(string _name , string _classe , int _life , int _stam , int _speed, string _def , string _abili , string _HeroicF , int _might , int _int , int _will , int _aware) {

            setName(_name);
            setClasse(_classe);

            //Characteristics
            setHealth(_life);
            setStamina(_stam);
            setSpeed(_speed);
            setDefense(_def);

            //Hero Ability
            setAbility(_abili);
            setHeroicFeat(_HeroicF);


            //Attributes
            setMight(_might);
            setKnowledge(_int);
            setWillpower(_will);
            setAwareness(_aware);
        }

        public void setName( string entry ) {
            if (entry != null) {
                pName = entry;
            }
        }

        public string getName() {
            return pName;
        }

        public void setClasse(string entry)
        {
            if (entry != null)
            {
                pClasse = entry;
            }
        }

        public string getClasse()
        {
            return pClasse;
        }

        public void setDefense(string entry)
        {
            if (entry != null)
            {
                pDefense = entry;
            }
        }

        public string getDefense()
        {
            return pDefense;
        }

        public void setAbility(string entry)
        {
            if (entry != null)
            {
                pAbility = entry;
            }
        }

        public string getAbility()
        {
            return pAbility;
        }

        public void setHeroicFeat(string entry)
        {
            if (entry != null)
            {
                pHeroicFeat = entry;
            }
        }

        public string getHeroicFeat()
        {
            return pHeroicFeat;
        }

        public void setHealth(int entry)
        {
            pHealth = entry < -1 ? 0 : entry;
        }

        public int getHealth()
        {
            return pHealth;
        }

        public void setStamina(int entry)
        {
            pStamina = entry < -1 ? 0 : entry;
        }

        public int getStamina()
        {
            return pStamina;
        }

        public void setSpeed(int entry)
        {
            pSpeed = entry < -1 ? 0 : entry;
        }

        public int getSpeed()
        {
            return pSpeed;
        }

        public void setMight(int entry)
        {
            pMight = entry < -1 ? 0 : entry;
        }

        public int getMight()
        {
            return pMight;
        }

        public void setKnowledge(int entry)
        {
            pKnowledge = entry < -1 ? 0 : entry;
        }

        public int getKnowledge()
        {
            return pKnowledge;
        }

        public void setWillpower(int entry)
        {
            pWillpower = entry < -1 ? 0 : entry;
        }

        public int getWillpower()
        {
            return pWillpower;
        }

        public void setAwareness(int entry)
        {
            pAwareness = entry < -1 ? 0 : entry;
        }

        public int getAwareness()
        {
            return pAwareness;
        }

    }
}
