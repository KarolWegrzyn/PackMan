using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Generator : MonoBehaviour
{
    public GameObject point_prefab;

    private float[] x = new float[82];
    private float[] y = new float[82];
    private int[] line = new int[82];
    private int up = 0;

    void Awake()
    {
        x[0] = 1.5f;
        y[0] = -3.5f;

        x[1] = 1.5f;
        y[1] = -4.5f;
        
        x[2] = 2.5f;
        y[2] = -5.5f;

        x[3] = 4.5f;
        y[3] = -2.5f;

        x[4] = 6.5f;
        y[4] = -2.5f;
        
        x[5] = 6.5f;
        y[5] = -4.5f;

        x[6] = 3.5f;
        y[6] = -1.5f;

        x[7] = 4.5f;
        y[7] = -6.5f;

        x[8] = 3.5f;
        y[8] = -7.5f;

        x[9] = 6.5f;
        y[9] = -6.5f;

        x[10] = 8.5f;
        y[10] = -2.5f;

        x[11] = 7.5f;
        y[11] = -7.5f;

        x[12] = 10.5f;
        y[12] = -4.5f;

        x[13] = 9.5f;
        y[13] = -1.5f;

        x[14] = 7.5f;
        y[14] = 0.5f;

        x[15] = 5.5f;
        y[15] = 2.5f;

        x[16] = 3.5f;
        y[16] = 2.5f;

        x[17] = 1.5f;
        y[17] = -8.5f;

        x[18] = 5.5f;
        y[18] = -9.5f;

        x[19] = 7.5f;
        y[19] = -9.5f;

        x[20] = 8.5f;
        y[20] = -6.5f;

        x[21] = 9.5f;
        y[21] = -5.5f;

        x[22] = 10.5f;
        y[22] = -0.5f;

        x[23] = 0.5f;
        y[23] = -9.5f;

        x[24] = 2.5f;
        y[24] = -9.5f;

        x[25] = 1.5f;
        y[25] = 3.5f;

        x[26] = 10.5f;
        y[26] = -8.5f;

        x[27] = 10.5f;
        y[27] = 1.5f;

        x[28] = 2.5f;
        y[28] = 4.5f;

        x[29] = 9.5f;
        y[29] = 2.5f;

        x[30] = 8.5f;
        y[30] = 3.5f;

        x[31] = 7.5f;
        y[31] = 6.5f;

        x[32] = 5.5f;
        y[32] = 6.5f;

        x[33] = 4.5f;
        y[33] = 5.5f;

        x[34] = 10.5f;
        y[34] = 5.5f;

        x[35] = 7.5f;
        y[35] = 9.5f;

        x[36] = 5.5f;
        y[36] = 9.5f;

        x[37] = 10.5f;
        y[37] = 7.5f;

        x[38] = 1.5f;
        y[38] = 7.5f;

        x[39] = 0.5f;
        y[39] = 7.5f;

        x[40] = 7.5f;
        y[40] = 4.5f;

        x[41] = -0.5f;
        y[41] = -3.5f;

        x[42] = -0.5f;
        y[42] = -3.5f;


        x[43] = -1.5f;
        y[43] = -5.5f;

        x[44] = -3.5f;
        y[44] = -2.5f;

        x[45] = -5.5f;
        y[45] = -2.5f;

        x[46] = -5.5f;
        y[46] = -4.5f;

        x[47] = -2.5f;
        y[47] = -1.5f;

        x[48] = -3.5f;
        y[48] = -6.5f;

        x[49] = -2.5f;
        y[49] = -7.5f;

        x[50] = -5.5f;
        y[50] = -6.5f;

        x[51] = -7.5f;
        y[51] = -2.5f;

        x[52] = -6.5f;
        y[52] = -7.5f;


        x[53] = -9.5f;
        y[53] = -4.5f;

        x[54] = -8.5f;
        y[54] = -1.5f;

        x[55] = -6.5f;
        y[55] = 0.5f;

        x[56] = -4.5f;
        y[56] = 2.5f;

        x[57] = -2.5f;
        y[57] = 2.5f;

        x[58] = -0.5f;
        y[58] = -8.5f;

        x[59] = -4.5f;
        y[59] = -9.5f;

        x[60] = -6.5f;
        y[60] = -9.5f;

        x[61] = -7.5f;
        y[61] = -6.5f;

        x[62] = -8.5f;
        y[62] = -5.5f;

        x[63] = -9.5f;
        y[63] = -0.5f;



        x[65] = -1.5f;
        y[65] = -9.5f;

        x[66] = -0.5f;
        y[66] = 3.5f;

        x[67] = -9.5f;
        y[67] = -8.5f;

        x[68] = -9.5f;
        y[68] = 1.5f;

        x[69] = -1.5f;
        y[69] = 4.5f;

        x[70] = -8.5f;
        y[70] = 2.5f;

        x[71] = -7.5f;
        y[71] = 3.5f;

        x[72] = -6.5f;
        y[72] = 6.5f;

        x[73] = -4.5f;
        y[73] = 6.5f;

        x[74] = -3.5f;
        y[74] = 5.5f;

        x[75] = -9.5f;
        y[75] = 5.5f;

        x[76] = -6.5f;
        y[76] = 9.5f;

        x[77] = -4.5f;
        y[77] = 9.5f;

        x[78] = -9.5f;
        y[78] = 7.5f;

        x[79] = -0.5f;
        y[79] = 7.5f;

        x[81] = -6.5f;
        y[81] = 4.5f;



        line[0] = 11;
        line[1] = 3;
        line[2] = 5;
        line[3] = 6;
        line[4] = 13;
        line[5] = 1;
        line[6] = 4;
        line[7] = 2;
        line[8] = 3;
        line[9] = 4;
        line[10] = 2;
        line[11] = 4;
        line[12] = 2;
        line[13] = 2;
        line[14] = 4;
        line[15] = 1;
        line[16] = 4;
        line[17] = 2;
        line[18] = 2;
        line[19] = 4;
        line[20] = 2;
        line[21] = 1;
        line[22] = 1;
        line[23] = 1;
        line[24] = 2;
        line[25] = 2;
        line[26] = 1;
        line[27] = 2;
        line[28] = 3;
        line[29] = 2;
        line[30] = 1;
        line[31] = 4;
        line[32] = 5;
        line[33] = 1;
        line[34] = 1;
        line[35] = 3;
        line[36] = 4;
        line[37] = 3;
        line[38] = 3;
        line[39] = 1;
        line[40] = 4;
    }

    private void Update()
    {
        up++;

        if (line[0] > 0 && up > 0)
        {
            Instantiate(point_prefab); //tworzymy obiekt z prefaba
            point_prefab.transform.position = new Vector3(x[0], y[0], 0); //zmieniamy pozycjê
            x[0]++; //aktualizujemy pozycje nastepnego obiektu
            line[0]--; //aktualizujemi liczbê obiektów do utworzenia

            Instantiate(point_prefab); //tworzymy obiekt z prefaba
            point_prefab.transform.position = new Vector3(x[41], y[41], 0); //zmieniamy pozycjê
            x[41]--; //aktualizujemy pozycje nastepnego obiektu
        }
        if(line[1] > 0 && up>1) 
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[1], y[1], 0);
            y[1]--;
            line[1]--;

            Instantiate(point_prefab); 
            point_prefab.transform.position = new Vector3(x[42], y[42], 0); 
            y[42]--; 
        }
        if (line[2] > 0 && up>3)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[2], y[2], 0);
            x[2]++;
            line[2]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[43], y[43], 0);
            x[43]--;
        }
        if (line[3] > 0 && up>4)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[3], y[3], 0);
            y[3]++;
            line[3]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[44], y[44], 0);
            y[44]++;
            
        }
        if (line[4] > 0 && up>6)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[4], y[4], 0);
            y[4]++;
            line[4]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[45], y[45], 0);
            y[45]++;
        }
        if (line[5] > 0 && up>6)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[5], y[5], 0);
            line[5]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[46], y[46], 0);
        }
        if (line[6] > 0 && up>6)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[6], y[6], 0);
            x[6]--;
            line[6]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[47], y[47], 0);
            x[47]++;
        }
        if (line[7] > 0 && up>6)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[7], y[7], 0);
            y[7]--;
            line[7]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[48], y[48], 0);
            y[48]--;
        }
        if (line[8] > 0 && up>8)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[8], y[8], 0);
            x[8]--;
            line[8]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[49], y[49], 0);
            x[49]++;
        }
        if (line[9] > 0 && up>8)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[9], y[9], 0);
            y[9]--;
            line[9]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[50], y[50], 0);
            y[50]--;
        }
        if (line[10] > 0 && up>8)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[10], y[10], 0);
            y[10]++;
            line[10]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[51], y[51], 0);
            y[51]++;
        }
        if (line[11] > 0 && up>10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[11], y[11], 0);
            x[11]++;
            line[11]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[52], y[52], 0);
            x[52]--;
        }
        if (line[12] > 0 && up > 10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[12], y[12], 0);
            y[12]--;
            line[12]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[53], y[53], 0);
            y[53]--;
        }
        if (line[13] > 0 && up > 10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[13], y[13], 0);
            x[13]++;
            line[13]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[54], y[54], 0);
            x[54]--;
        }
        if (line[14] > 0 && up > 10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[14], y[14], 0);
            x[14]++;
            line[14]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[55], y[55], 0);
            x[55]--;

        }
        if (line[15] > 0 && up > 10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[15], y[15], 0);
            line[15]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[56], y[56], 0);
        }
        if (line[16] > 0 && up > 10)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[16], y[16], 0);
            x[16]--;
            line[16]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[57], y[57], 0);
            x[57]++;
        }
        if (line[17] > 0 && up > 11)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[17], y[17], 0);
            y[17]--;
            line[17]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[58], y[58], 0);
            y[58]--;
        }
        if (line[18] > 0 && up > 12)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[18], y[18], 0);
            x[18]--;
            line[18]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[59], y[59], 0);
            x[59]++;
        }
        if (line[19] > 0 && up > 12)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[19], y[19], 0);
            x[19]++;
            line[19]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[60], y[60], 0);
            x[60]--;
        }
        if (line[20] > 0 && up > 12)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[20], y[20], 0);
            y[20]++;
            line[20]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[61], y[61], 0);
            y[61]++;
        }
        
        if (line[21] > 0 && up > 12)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[21], y[21], 0);
            line[21]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[62], y[62], 0);
        }
        if (line[22] > 0 && up > 12)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[22], y[22], 0);
            line[22]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[63], y[63], 0);
        }
        if (line[23] > 0 && up > 13)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[23], y[23], 0);
            line[23]--; //x[64] - pusty
        }
        if (line[24] > 0 && up > 13)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[24], y[24], 0);
            x[24]++;
            line[24]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[65], y[65], 0);
            x[65]--;
        }
        if (line[25] > 0 && up > 13)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[25], y[25], 0);
            y[25]++; 
            line[25]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[66], y[66], 0);
            y[66]++;
        }
        if (line[26] > 0 && up > 14)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[26], y[26], 0);
            line[26]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[67], y[67], 0);
        }
        if (line[27] > 0 && up > 14)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[27], y[27], 0);
            y[27]++;
            line[27]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[68], y[68], 0);
            y[68]++;
        }
        if (line[28] > 0 && up > 15)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[28], y[28], 0);
            x[28]++;
            line[28]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[69], y[69], 0);
            x[69]--;
        }
        if (line[29] > 0 && up > 16)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[29], y[29], 0);
            x[29]--;
            line[29]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[70], y[70], 0);
            x[70]++;
        }
        if (line[30] > 0 && up > 16)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[30], y[30], 0);
            line[30]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[71], y[71], 0);
        }
        
        if (line[31] > 0 && up > 16)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[31], y[31], 0);
            x[31]++;
            line[31]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[72], y[72], 0);
            x[72]--;
        }
        if (line[32] > 0 && up > 16)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[32], y[32], 0);
            x[32]--;
            line[32]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[73], y[73], 0);
            x[73]++;
        }
        if (line[33] > 0 && up > 18)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[33], y[33], 0);
            line[33]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[74], y[74], 0);
        }
        if (line[34] > 0 && up > 18)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[34], y[34], 0);
            line[34]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[75], y[75], 0);
        }
        if (line[35] > 0 && up > 19)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[35], y[35], 0);
            x[35]++;
            line[35]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[76], y[76], 0);
            x[76]--;
        }
        if (line[36] > 0 && up > 19)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[36], y[36], 0);
            x[36]--;
            line[36]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[77], y[77], 0);
            x[77]++;
        }
        if (line[37] > 0 && up > 20)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[37], y[37], 0);
            y[37]++;
            line[37]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[78], y[78], 0);
            y[78]++;
        }
        if (line[38] > 0 && up > 21)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[38], y[38], 0);
            y[38]++;
            line[38]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[79], y[79], 0);
            y[79]++;
        }
        if (line[39] > 0 && up > 22)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[39], y[39], 0);
            line[39]--;
            //x[80]
        }
        if (line[40] > 0 && up > 16)
        {
            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[40], y[40], 0);
            x[40]++;
            line[40]--;

            Instantiate(point_prefab);
            point_prefab.transform.position = new Vector3(x[81], y[81], 0);
            x[81]--;
        }

    }

}
