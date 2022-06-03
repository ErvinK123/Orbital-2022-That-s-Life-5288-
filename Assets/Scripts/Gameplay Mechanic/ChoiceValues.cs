using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceValues : MonoBehaviour
{
    // {Career, Popularity, Health, LifeSkills, Morals}
    public static int[,,] childResult = new int[3, 3, 5] { {{0, 0, -5, 0, -5} // Child 1
                                                          , {0, 5, 0, 0, 5}
                                                          , {0, 0, 0, 0, 0}}

                                                          , {{0, 0, 0, 0, -5} // Child 2 
                                                          , {0, 0, 0, 10, -5},
                                                           {0 , 10, -5, 5, 0}}
        
                                                          , {{5, -5, 0, 0, 0} // Child 3 
                                                          , {0, 5, 0, 0, -5},
                                                           {0 , 0, 0, 0, 0}}};

    public static int[,,] teenResult = new int[3, 3, 5] { {{5, -5, -5, 5, 0} // Teen 1
                                                          , {-5, -5, 5, 0, 0}
                                                          , {5, -10, 0, 0, 5}}

                                                          , {{5, -10, 0, 0, 5} // Teen 2  
                                                          , {0, 5, 5, 0, -5},
                                                           {0 , 0, 0, 0, 0}}
                                                            
                                                          , {{-10, 5, 0, 0, 0} // Teen 3  
                                                          , {10, -5, 0, 10, -5},
                                                           {0 , -10, 0, 0, 10}}};

    public static int[,,] adultResult = new int[3, 3, 5] { {{5, 0, -5, 0, 0} // Adult 1
                                                          , {-5, 0, 5, 0, 0}
                                                          , {5, -5, 0, 0, 0}}

                                                          , {{0, 0, 0, 5, 0} // Adult 2 
                                                          , {0, 0, 0, -5, 0},
                                                           {0 , 0, 0, 0, 0}}

                                                          , {{0, 5, 0, 0, 0} // Adult 3 
                                                          , {0, -5, 0, 0, 0},
                                                           {0 , 0, 0, 0, 0}}};

    public static int[,,] elderResult = new int[3, 3, 5] { {{0, 0, 0, 0, -5} // Elder 1 
                                                          , {0, 0, 5, 0, 0}
                                                          , {0, 5, 0, 0, 0}}

                                                          , {{0, -10, 0, 0, 0} // Elder 2 
                                                          , {0, 10, 0, 0, 0},
                                                           {0 , 0, 0, 0, 0}}

                                                          , {{0, 0, -5, 0, 0} // Elder 3 
                                                          , {0, 0, 0, 10, 0},
                                                           {0 , 0, 0, 0, 0}}};
}
