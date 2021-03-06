/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DOL.Tools.QuestDesigner.Util
{
    [Serializable]
    public class ClipboardLocation
    {
        private static DataFormats.Format m_Format;

        public static DataFormats.Format Format
        {
            get
            {
                if (m_Format == null)
                    m_Format = DataFormats.GetFormat(typeof(ClipboardLocation).FullName);
                return m_Format;
            }
        }

        private int m_X;

        public int X
        {
            get { return m_X; }
            set { m_X = value; }
        }

        private int m_Y;

        public int Y
        {
            get { return m_Y; }
            set { m_Y = value; }
        }

        private int m_Z;

        public int Z
        {
            get { return m_Z; }
            set { m_Z = value; }
        }

        private int m_RegionID;

        public int RegionID
        {
            get { return m_RegionID; }
            set { m_RegionID = value; }
        }
        
        public int ZoneID
        {
            get { return Utils.GetZoneIDForLocation(RegionID, X, Y); }            
        }

        private int m_Heading;

        public int Heading
        {
            get { return m_Heading; }
            set { m_Heading = value; }
        }

        public int LocalX
        {
            get
            {
                return Utils.ConvertRegionXToZone(ZoneID, X);
            }
            set
            {
                X = Utils.ConvertZoneXToRegionByRegionID(RegionID,value);
            }
        }

        public int LocalY
        {
            get
            {
                return Utils.ConvertRegionYToZone(ZoneID, Y);
            }
            set
            {
                Y = Utils.ConvertZoneYToRegionByRegionID(RegionID,value);
            }
        }

        public int LocalZ
        {
            get
            {
                return Z;
            }
            set
            {
                Z = value;
            }
        }        

        public ClipboardLocation(int x, int y, int z, int regionID, int heading)
        {
            X = x;
            Y = y;
            Z = z;
            RegionID = regionID;
            Heading = heading;
        }
        
        public ClipboardLocation(int x, int y, int z, int regionID) : this (x,y,z,regionID,-1) { }

        public ClipboardLocation(int x, int y , int regionID) : this(x, y, 0, regionID, -1) { }
	
    }
}
