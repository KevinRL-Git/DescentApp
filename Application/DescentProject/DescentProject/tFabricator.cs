using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescentProject
{
    class tFabricator
    {
        private tFabricator himself = null;

        public tFabricator getFabricator() {
            if ( himself == null ) {
                himself = new tFabricator();
            }
            return himself;
        }

        public void createQuest() {
        }
        public tPersonnage createPersonnage(string _name, string _classe, int _life, int _stam, int _speed, string _def, string _abili, string _HeroicF, int _might, int _int, int _will, int _aware)
        {
            tPersonnage newPerso = new tPersonnage( _name, _classe, _life, _stam, _speed, _def, _abili, _HeroicF, _might, _int, _will, _aware);

            return newPerso;
        }

        public void createMonsterOpenGroup(){
        }

        public void createLieutenant(){
        }
    }
}
