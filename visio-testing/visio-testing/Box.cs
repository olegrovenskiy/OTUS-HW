using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ids.OrganogramDesigner
{
    public class Box
    {
        private string name;
        private string id;
        private Box parent;

        private int levelNumber;
        private int number;
        private int displayOrder;

        private Color backColor = Color.White;
        private Colors foreColor = Colors.Black;

        private double width = 0.7;
        private double height = 0.5;

        private BoxTypes type = BoxTypes.Position;

        private string hyperlink = "";

        public Box()
        {

        }


        public Box(string id, string name, string parentId, int levelNumber)
        {
            this.id = id;
            this.name = name;
            this.levelNumber = levelNumber;

            this.parent = new Box();
            this.parent.id = parentId;
        }

        public Box(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.levelNumber = 0;
            this.width = 1.0;
        }

        public string HyperLink
        {
            get
            {
                return hyperlink;
            }
            set
            {
                hyperlink = value;
            }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int LevelNumber
        {
            get { return levelNumber; }
            set { levelNumber = value; }
        }

        public int DisplayOrder
        {
            get { return displayOrder; }
            set { displayOrder = value; }
        }

        public Colors ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }

        public Box Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public BoxTypes Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

    }
}
