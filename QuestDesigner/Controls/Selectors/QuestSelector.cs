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
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DOL.Tools.QuestDesigner.Util;
using System.Reflection;
using System.Data;

namespace DOL.Tools.QuestDesigner.Controls
{
	[SelectorAttribute(Const.SELECTOR_QUESTTYPE)]
	public class QuestSelector : BaseSelector
	{		

		public QuestSelector(int triggerID, char param): base(triggerID,param)
		{
			foreach (DataRow row in DB.QuestTable.Rows)
			{
                this.list.Items.Add(row[DB.COL_QUEST_NAMESPACE] + "." + row[DB.COL_QUEST_NAME]);
			}
		}

		protected override System.Drawing.Image getImage(int index)
		{
			return global::DOL.Tools.QuestDesigner.Properties.Resources.quest;
		}	
		
	}
}
