using UnityEngine;
using System.Collections;

namespace Programme
{
    public class Team
    {
        private string clan;
        private int zinc;
        private int roche;
        private int uranium;
        private int unit;

        public Team(string clan)
        {
            this.clan = clan;
            zinc = 100;
            roche = 100;
            uranium = 100;
            unit = 1;
        }

        public string get_clan()
        {
            return (clan);
        }

        public int get_zinc()
        {
            return (zinc);
        }

        public int get_roche()
        {
            return (roche);
        }

        public int get_uranium()
        {
            return (uranium);
        }

        public int get_unit()
        {
            return (unit);
        }

        public void set_clan(string clan)
        {
            this.clan = clan;
        }

        public void add_zinc(int nbr)
        {
            zinc = zinc + nbr;
        }

        public void add_roche(int nbr)
        {
            roche = roche + nbr;
        }

        public void add_uranium(int nbr)
        {
            uranium = uranium + nbr;
        }

        public void add_unit(int nbr)
        {
            unit = unit + nbr;
        }
    }
}
