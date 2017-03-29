using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LBS
{
    class DataSet
    {
        Random rnd = new Random();
        public int getRandomData(List<int[]> lst,ref int X, ref int Y)
        {
            var resX = new List<int>();
            var resY = new List<int>();
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (X + i >= 0 && Y + j >=0 && X + i < lst.Count && Y + j < lst[0].Count())
                    {
                        if (X + i != X || Y + j != Y)
                        {
                            resX.Add(i);
                            resY.Add(j);
                        }
                        
                    }
                }
            }
            var ranIndex = rnd.Next(0, resX.Count);
            X += resX[ranIndex];
            Y += resY[ranIndex];
            return lst[X][Y];
        }
        public void genDataSet()
        {

            List<int[]> cell = new List<int[]>();
            cell.Add(new int[] { 0, 1, 2, 3, 4, 25, 26, 27, 28, 29, 50, 51, 52, 53, 54, 75, 76, 77, 78, 79, 100, 101, 102, 103, 104 });
            cell.Add(new int[] { 5, 6, 7, 8, 9, 30, 31, 32, 33, 34, 55, 56, 57, 58, 59, 80, 81, 82, 83, 84, 105, 106, 107, 108, 109 }); ;
            cell.Add(new int[] { 10, 11, 12, 13, 14, 35, 36, 37, 38, 39, 60, 61, 62, 63, 64, 85, 86, 87, 88, 89, 110, 111, 112, 113, 114 });
            cell.Add(new int[] { 15, 16, 17, 18, 19, 40, 41, 42, 43, 44, 65, 66, 67, 68, 69, 90, 91, 92, 93, 94, 115, 116, 117, 118, 119 });
            cell.Add(new int[] { 20, 21, 22, 23, 24, 45, 46, 47, 48, 49, 70, 71, 72, 73, 74, 95, 96, 97, 98, 99, 120, 121, 122, 123, 124 });
            cell.Add(new int[] { 125, 126, 127, 128, 129, 150, 151, 152, 153, 154, 175, 176, 177, 178, 179, 200, 201, 202, 203, 204, 225, 226, 227, 228, 229 });
            cell.Add(new int[] { 130, 131, 132, 133, 134, 155, 156, 157, 158, 159, 180, 181, 182, 183, 184, 205, 206, 207, 208, 209, 230, 231, 232, 233, 234 });
            cell.Add(new int[] { 135, 136, 137, 138, 139, 160, 161, 162, 163, 164, 185, 186, 187, 188, 189, 210, 211, 212, 213, 214, 235, 236, 237, 238, 239 });
            cell.Add(new int[] { 140, 141, 142, 143, 144, 165, 166, 167, 168, 169, 190, 191, 192, 193, 194, 215, 216, 217, 218, 219, 240, 241, 242, 243, 244 });
            cell.Add(new int[] { 145, 146, 147, 148, 149, 170, 171, 172, 173, 174, 195, 196, 197, 198, 199, 220, 221, 222, 223, 224, 245, 246, 247, 248, 249 });
            cell.Add(new int[] { 250, 251, 252, 253, 254, 275, 276, 277, 278, 279, 300, 301, 302, 303, 304, 325, 326, 327, 328, 329, 350, 351, 352, 353, 354 });
            cell.Add(new int[] { 255, 256, 257, 258, 259, 280, 281, 282, 283, 284, 305, 306, 307, 308, 309, 330, 331, 332, 333, 334, 355, 356, 357, 358, 359 });
            cell.Add(new int[] { 260, 261, 262, 263, 264, 285, 286, 287, 288, 289, 310, 311, 312, 313, 314, 335, 336, 337, 338, 339, 360, 361, 362, 363, 364 });
            cell.Add(new int[] { 265, 266, 267, 268, 269, 290, 291, 292, 293, 294, 315, 316, 317, 318, 319, 340, 341, 342, 343, 344, 365, 366, 367, 368, 369 });
            cell.Add(new int[] { 270, 271, 272, 273, 274, 295, 296, 297, 298, 299, 320, 321, 322, 323, 324, 345, 346, 347, 348, 349, 370, 371, 372, 373, 374 });
            cell.Add(new int[] { 375, 376, 377, 378, 379, 400, 401, 402, 403, 404, 425, 426, 427, 428, 429, 450, 451, 452, 453, 454, 475, 476, 477, 478, 479 });
            cell.Add(new int[] { 380, 381, 382, 383, 384, 405, 406, 407, 408, 409, 430, 431, 432, 433, 434, 455, 456, 457, 458, 459, 480, 481, 482, 483, 484 });
            cell.Add(new int[] { 385, 386, 387, 388, 389, 410, 411, 412, 413, 414, 435, 436, 437, 438, 439, 460, 461, 462, 463, 464, 485, 486, 487, 488, 489 });
            cell.Add(new int[] { 390, 391, 392, 393, 394, 415, 416, 417, 418, 419, 440, 441, 442, 443, 444, 465, 466, 467, 468, 469, 490, 491, 492, 493, 494 });
            cell.Add(new int[] { 395, 396, 397, 398, 399, 420, 421, 422, 423, 424, 445, 446, 447, 448, 449, 470, 471, 472, 473, 474, 495, 496, 497, 498, 499 });
            cell.Add(new int[] { 500, 501, 502, 503, 504, 525, 526, 527, 528, 529, 550, 551, 552, 553, 554, 575, 576, 577, 578, 579, 600, 601, 602, 603, 604 });
            cell.Add(new int[] { 505, 506, 507, 508, 509, 530, 531, 532, 533, 534, 555, 556, 557, 558, 559, 580, 581, 582, 583, 584, 605, 606, 607, 608, 609 });
            cell.Add(new int[] { 510, 511, 512, 513, 514, 535, 536, 537, 538, 539, 560, 561, 562, 563, 564, 585, 586, 587, 588, 589, 610, 611, 612, 613, 614 });
            cell.Add(new int[] { 515, 516, 517, 518, 519, 540, 541, 542, 543, 544, 565, 566, 567, 568, 569, 590, 591, 592, 593, 594, 615, 616, 617, 618, 619 });
            cell.Add(new int[] { 520, 521, 522, 523, 524, 545, 546, 547, 548, 549, 570, 571, 572, 573, 574, 595, 596, 597, 598, 599, 620, 621, 622, 623, 624 });

            List<int> lastCellX = new List<int>();
            List<int> lastCellY = new List<int>();
            int numberOfPhone = 2000;
            
            for (int i = 0; i < numberOfPhone; i++)
            {
                lastCellX.Add(rnd.Next(0, 25));
                lastCellY.Add(rnd.Next(0, 25));
            }

            //int x = 0, y = 0;
            //Console.WriteLine(getRandomData(cell, ref x, ref y));

            
            int numberOfMT = 2000;
            int numberOfDay = 1;
            int minutePerDay = 3 * 24;
            int minCallPerMinute = 30, maxCallPerMinute = 1300;
            int minMovePerMinute = 50, maxMovePerMinute = 1500;

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("days");
            xmlDoc.AppendChild(rootNode);

            for (int i = 0; i < numberOfDay; i++)
            {
                XmlNode dayNode = xmlDoc.CreateElement("day");
                rootNode.AppendChild(dayNode);
                XmlAttribute dayAtt = xmlDoc.CreateAttribute("val");
                dayAtt.Value = (i + 1).ToString();
                dayNode.Attributes.Append(dayAtt);

                for (int j = 0; j < minutePerDay; j++)
                {
                    XmlNode minuteNode = xmlDoc.CreateElement("minute");
                    XmlAttribute minuteAtt = xmlDoc.CreateAttribute("val");
                    minuteAtt.Value = j.ToString();
                    minuteNode.Attributes.Append(minuteAtt);

                    int callPerMinute = rnd.Next(minCallPerMinute, maxCallPerMinute + 1);
                    int movePerMinute = rnd.Next(minMovePerMinute, maxMovePerMinute + 1);

                    for (int k = 0; k < movePerMinute; k++)
                    {
                        XmlNode moveNode = xmlDoc.CreateElement("move");
                        int MTIndex = rnd.Next(0, numberOfMT);
                        int lastMTCellX = lastCellX[MTIndex], lastMTCellY = lastCellY[MTIndex];
                        moveNode.InnerText = String.Format("{0}:{1}", "MT" + MTIndex.ToString(), "C" + getRandomData(cell, ref lastMTCellX, ref lastMTCellY).ToString());
                        lastCellX[MTIndex] = lastMTCellX;
                        lastCellY[MTIndex] = lastMTCellY;

                        minuteNode.AppendChild(moveNode);
                    }

                    for (int k = 0; k < callPerMinute; k++)
                    {
                        XmlNode callNode = xmlDoc.CreateElement("call");
                        int MTIndex1 = rnd.Next(0, numberOfMT);
                        int MTIndex2 = rnd.Next(0, numberOfMT);
                        callNode.InnerText = String.Format("{0}:{1}", "MT" + MTIndex1.ToString(), "MT" + MTIndex2.ToString());

                        minuteNode.AppendChild(callNode);
                    }

                    dayNode.AppendChild(minuteNode);
                }
                rootNode.AppendChild(dayNode);
            }
            xmlDoc.Save("LBS-DataSet-" + DateTime.Now.ToString("yyyyMMddhhMM") + ".xml");
            Console.WriteLine("Done");
        }
    }
}
