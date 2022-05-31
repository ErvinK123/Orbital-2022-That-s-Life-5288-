using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceValues : MonoBehaviour
{
    // {Career, Popularity, Health, Life Skills, Morals}
    //public static int[,,] arr = new int[8, 3, 5] { {{0, 0, -5, 0, -5} // Child 1
    //                                          , {0, 5, 0, 0, 5}
    //                                          , {0, 0, 0, 0, 0}}
    //                                        , {{0, 0, 0, 0, -5} // Child 2 
    //                                          , {0, 0, 0, 10, -5},
    //                                            {0 , 10, -5, 5, 0}}
    //                                        , {{5, -5, -5, 5, 0} // Teen 1 
    //                                          , {-5, -5, 5, 0, 0}
    //                                          , {5, -10, 0, 0, 5}}
    //                                        , {{5, -10, 0, 0, 5} // Teen 2 
    //                                          , {0, 5, 5, 0, -5}
    //                                          , {0, 0, 0, 0, 0}}
    //                                        , {{5, 0, -5, 0, 0} // Adult 1 
    //                                          , {-5, 0, 5, 0, 0}
    //                                          , {5, -5, 0, 0, 0}}
    //                                        , {{0, 0, 0, 5, 0}  // Adult 1 
    //                                          , {0, 0, 0, -5, 0}
    //                                          , {0, 0, 0, 0, 0}} 
    //                                        , {{0, 0, 0, 0, -5} // Scenario 7
    //                                          , {0, 0, 5, 0, 0}
    //                                          , {0, 5 ,0, 0, 0}}
    //                                        , {{0, -10, 0, 0, 0} // Scenario 8
    //                                          , {0, 10, 0, 0, 0}
    //                                          , {0, 0, 0, 0, 0}}};


    public static int[,,] childResult = new int[2, 3, 5] { {{0, 0, -5, 0, -5} // Child 1
                                                          , {0, 5, 0, 0, 5}
                                                          , {0, 0, 0, 0, 0}}

                                                          , {{0, 0, 0, 0, -5} // Child 2 
                                                          , {0, 0, 0, 10, -5},
                                                           {0 , 10, -5, 5, 0}}};

    public static int[,,] teenResult = new int[2, 3, 5] { {{5, -5, -5, 5, 0} // Teen 1
                                                          , {-5, -5, 5, 0, 0}
                                                          , {5, -10, 0, 0, 5}}

                                                          , {{5, -10, 0, 0, 5} // Teen 2  
                                                          , {0, 5, 5, 0, -5},
                                                           {0 , 0, 0, 0, 0}}};

    public static int[,,] adultResult = new int[2, 3, 5] { {{5, 0, -5, 0, 0} // Adult 1
                                                          , {-5, 0, 5, 0, 0}
                                                          , {5, -5, 0, 0, 0}}

                                                          , {{0, 0, 0, 5, 0} // Adult 2 
                                                          , {0, 0, 0, -5, 0},
                                                           {0 , 0, 0, 0, 0}}};

    public static int[,,] elderResult = new int[2, 3, 5] { {{0, 0, 0, 0, -5} // Elder 1 
                                                          , {0, 0, 5, 0, 0}
                                                          , {0, 5, 0, 0, 0}}

                                                          , {{0, -10, 0, 0, 0} // Elder 2 
                                                          , {0, 10, 0, 0, 0},
                                                           {0 , 0, 0, 0, 0}}};
}
