using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptScripts : MonoBehaviour
{
    public static AcceptScripts acceptinstance;

    public GameObject leftslider;
    public GameObject rightslider;


    private void Awake()
    {
        makeinstance();
    }

    void makeinstance()
    {
        if(acceptinstance == null)
        {
            acceptinstance = this;
        }
    }
    public void acceptbutton()
    {
        //if (tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney <= 0)
        //{
        //    AcceptScripts.acceptinstance.leftslider.transform.gameObject.SetActive(false);
        //}
        //if (tradingmoneyscripts.tradingmoneyinstance.righttransfermoney <= 0)
        //{
        //    AcceptScripts.acceptinstance.rightslider.transform.gameObject.SetActive(false);
        //}
        /// when player one is on left side
        if (TBSMManager.tbmsinstance.p1b2 == true)
        {
            TBSMManager.tbmsinstance.p1b2 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player2counter += 1;
                       
                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();



                    }
                }
            }
            
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();

                       
                        
                       
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p1b3 == true)
        {
            TBSMManager.tbmsinstance.p1b3 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player3counter += 1;
                        
                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

                      
                        
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p1b4 == true)
        {
            TBSMManager.tbmsinstance.p1b4 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player4counter += 1;

                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        
                        
                    }
                }
            }
        }
        // whem player two is on left side
        if (TBSMManager.tbmsinstance.p2b1 == true)
        {
            TBSMManager.tbmsinstance.p2b1 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();



                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player2counter += 1;

                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();

                       
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p2b3 == true)
        {
            TBSMManager.tbmsinstance.p2b3 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player3counter += 1;

                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player2counter += 1;

                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

                        
                       
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p2b4 == true)
        {
            TBSMManager.tbmsinstance.p2b4 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player4counter += 1;

                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player2counter += 1;

                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                       
                       
                    }
                }
            }
        }
        // when player three is on left side
        if (TBSMManager.tbmsinstance.p3b1 == true)
        {
            TBSMManager.tbmsinstance.p3b1 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();

                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player3counter += 1;

                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                       
                        
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p3b2 == true)
        {
            TBSMManager.tbmsinstance.p3b2 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player2counter += 1;

                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player3counter += 1;

                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                       
                       
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p3b4 == true)
        {
            TBSMManager.tbmsinstance.p3b4 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player4counter += 1;

                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player3counter += 1;

                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                       
                       
                    }
                }
            }
        }

        // when player four is on the left side
        if (TBSMManager.tbmsinstance.p4b1 == true)
        {
            TBSMManager.tbmsinstance.p4b1 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 1;
                        shiftingplayermarkP1(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer1[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player1counter += 1;

                        PanelManager.instance.player1M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer1[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player1counter -= 1;
                        PanelManager.instance.player4counter += 1;

                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player1M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player1money.text = PanelManager.instance.player1M.ToString();
                       
                        
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p4b2 == true)
        {
            TBSMManager.tbmsinstance.p4b2 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 2;
                        shiftingplayermarkP2(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer2[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player2counter += 1;

                        PanelManager.instance.player2M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();

                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer2[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player2counter -= 1;
                        PanelManager.instance.player4counter += 1;


                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player2M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player2money.text = PanelManager.instance.player2M.ToString();
                       
                        
                    }
                }
            }
        }

        if (TBSMManager.tbmsinstance.p4b3 == true)
        {
            TBSMManager.tbmsinstance.p4b3 = false;
            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 3;
                        shiftingplayermarkP3(j);
                        PanelManager.instance.citylistofplayer4[j] = 0;
                        PanelManager.instance.citylistofplayer3[j] = j;
                        PanelManager.instance.player4counter -= 1;
                        PanelManager.instance.player3counter += 1;

                        PanelManager.instance.player3M -= tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                        PanelManager.instance.player4M += tradingmoneyscripts.tradingmoneyinstance.righttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();


                    }
                }
            }

            for (int i = 0; i <= 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                    {
                        PanelManager.instance.buyedby[j] = 4;
                        shiftingplayermarkP4(j);
                        PanelManager.instance.citylistofplayer3[j] = 0;
                        PanelManager.instance.citylistofplayer4[j] = j;
                        PanelManager.instance.player3counter -= 1;
                        PanelManager.instance.player4counter += 1;

                        PanelManager.instance.player4M -= tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player4money.text = PanelManager.instance.player4M.ToString();
                        PanelManager.instance.player3M += tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney;
                        PanelManager.instance.player3money.text = PanelManager.instance.player3M.ToString();
                       
                       
                    }
                }
            }
        }

        // from here closing of trading begin
       
        TBSMManager.tbmsinstance.offerbutton.transform.gameObject.SetActive(true);
        TBSMManager.tbmsinstance.cancelbutton.transform.gameObject.SetActive(true);

        tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney = 0;
        tradingmoneyscripts.tradingmoneyinstance.righttransfermoney = 0;

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.leftplayercity[j].transform.gameObject.SetActive(false);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.rightplayercity[j].transform.gameObject.SetActive(false);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            leftplayercitybutton.leftinstance.leftcities[i] = 0;
        }
        leftplayercitybutton.leftinstance.leftcitycounter = 1;
        for (int i = 0; i <= 40; i++)
        {
            rightplayercitybutton.rightinstance.rightcities[i] = 0;
        }
        rightplayercitybutton.rightinstance.rightcitycounter = 1;
        /// to close the trading panel and the player names
        racastdebugging.rayinstance.clickcityrepresentation = true;
        TBSMManager.tbmsinstance.TradePanel.transform.gameObject.SetActive(false);

        for (int i = 0; i < 5; i++)
        {
            TBSMManager.tbmsinstance.leftplayertrade[i].transform.gameObject.SetActive(false);
        }

        for (int j = 0; j < 5; j++)
        {
            TBSMManager.tbmsinstance.rightplayertrade[j].transform.gameObject.SetActive(false);
        }

    }

    public void rejectbutton()
    {

        TBSMManager.tbmsinstance.offerbutton.transform.gameObject.SetActive(true);
        TBSMManager.tbmsinstance.cancelbutton.transform.gameObject.SetActive(true);
        racastdebugging.rayinstance.clickcityrepresentation = true;
        TBSMManager.tbmsinstance.TradePanel.transform.gameObject.SetActive(false);

        tradingmoneyscripts.tradingmoneyinstance.lefttransfermoney = 0;
        tradingmoneyscripts.tradingmoneyinstance.righttransfermoney = 0;

        for (int i = 0; i < 5; i++)
        {
            TBSMManager.tbmsinstance.leftplayertrade[i].transform.gameObject.SetActive(false);
        }

        for (int j = 0; j < 5; j++)
        {
            TBSMManager.tbmsinstance.rightplayertrade[j].transform.gameObject.SetActive(false);
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (leftplayercitybutton.leftinstance.leftcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.leftplayercity[j].transform.gameObject.SetActive(false);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            for (int j = 1; j < 40; j++)
            {
                if (rightplayercitybutton.rightinstance.rightcities[i] == j)
                {
                    tradingfunctionality.tradinginstance.rightplayercity[j].transform.gameObject.SetActive(false);
                }
            }
        }

        for (int i = 0; i <= 40; i++)
        {
            leftplayercitybutton.leftinstance.leftcities[i] = 0;
        }
        leftplayercitybutton.leftinstance.leftcitycounter = 1;
        for (int i = 0; i <= 40; i++)
        {
            rightplayercitybutton.rightinstance.rightcities[i] = 0;
        }
        rightplayercitybutton.rightinstance.rightcitycounter = 1;
    }

    void shiftingplayermarkP1(int r)
    {
        // for player one
        PlayerToken.playerinstance.playersymbolforproperty[r].SetActive(false);
        PlayerToken.playerinstance.playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[0]);
        if (r < 10)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
        }
        if (r > 10 && r < 20)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
        }
        if (r > 20 && r < 30)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

        }
        if (r > 30 && r < 40)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
        }

    }

    void shiftingplayermarkP2(int r)
    {
        // for player two
        PlayerToken.playerinstance.playersymbolforproperty[r].SetActive(false);
        PlayerToken.playerinstance.playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[1]);
        if (r < 10)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
        }
        if (r > 10 && r < 20)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
        }
        if (r > 20 && r < 30)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

        }
        if (r > 30 && r < 40)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
        }

    }

    void shiftingplayermarkP3(int r)
    {
        // for player three
        PlayerToken.playerinstance.playersymbolforproperty[r].SetActive(false);
        PlayerToken.playerinstance.playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[2]);
        if (r < 10)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
        }
        if (r > 10 && r < 20)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
        }
        if (r > 20 && r < 30)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

        }
        if (r > 30 && r < 40)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
        }

    }

    void shiftingplayermarkP4(int r)
    {
        // for player four
        PlayerToken.playerinstance.playersymbolforproperty[r].SetActive(false);
        PlayerToken.playerinstance.playersymbolforproperty[r] = (GameObject)Instantiate(PanelManager.instance.playerSymbol[3]);
        if (r < 10)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(1.017f, 0, -(r + 0.05f));
        }
        if (r > 10 && r < 20)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(r - 10.018f), 0, -11.01f);
        }
        if (r > 20 && r < 30)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-11f, 0, -(30 - r));

        }
        if (r > 30 && r < 40)
        {
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.eulerAngles = new Vector3(0f, 90f, 0f);
            PlayerToken.playerinstance.playersymbolforproperty[r].transform.position = new Vector3(-(39.97f - r), 0, 1.021f);
        }

    }
}
