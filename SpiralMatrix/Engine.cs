using System;

namespace SpiralMatrix
{
    public class Engine
    {
        public int [,] Calculate(int size)
        {
            var spiralMatrix = new int[size, size];
            var boundary = 0;
            int xPos = 0;
            int yPos = 0;

            for (int counter = 0; counter < size*size; counter++)
            {
                var limit = size - boundary;

                //Move along xAxis forward
                if(xPos < limit  && yPos == boundary)
                {
                    spiralMatrix[xPos, yPos] = counter+1;

                    if (xPos < limit - 1)
                    {
                        xPos++;
                    }
                    else //switch direction to y axis forward
                        yPos++;
                }
                //Move along yaxis forward
                else if(xPos == limit - 1 && yPos > boundary)
                {
                    spiralMatrix[xPos, yPos] = counter + 1;

                    if (yPos < limit -1)
                    {
                        yPos++;
                    }
                    else //switch direction to x axis backward
                        xPos--;
                }
                //Move along xAxis backward
                else if (xPos >= boundary && yPos == limit - 1)
                {
                    spiralMatrix[xPos, yPos] = counter + 1;

                    if (xPos > boundary)
                    {
                        xPos--;
                    }
                    else //switch direction to y axis backward
                        yPos--;
                }
                //Move along yAxis backward
                else if (xPos == boundary && yPos > boundary)
                {
                    spiralMatrix[xPos, yPos] = counter + 1;

                    if(yPos == boundary + 1)
                    {
                        xPos++;
                        boundary++;
                    }
                    else
                        yPos--;
                }


            }

            return spiralMatrix;
        }
    }
}
