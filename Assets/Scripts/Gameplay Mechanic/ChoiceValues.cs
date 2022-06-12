using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceValues : MonoBehaviour
{
    // {Career, Popularity, Health, LifeSkills, Morals

    //Child 
    public static int[,,] childResult = new int[6, 3, 5] { {{0, 0, -5, 0, -5} // Child 1
                                                          , {0, 5, 0, 0, 5}
                                                          , {0, 0, 0, 0, 0}}

                                                          , {{0, 0, 0, 0, -5} // Child 2 
                                                          , {0, 0, 0, 0, -5},
                                                           {0, 0, 0, 5, 0}}
        
                                                          , {{5, -5, 0, 0, 0} // Child 3 
                                                          , {0, 5, 0, 0, -5},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, -5, 0, 0, 0} // Child 4 
                                                          , {0, 5, 0, 0, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 0, 10, 0, 0} // Child 5 
                                                          , {0, 5, 0, 0, 5},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, -5, 0, 5, 0} // Child 6
                                                          , {0, -5, -5, 0, 5},
                                                           {0, 5, -5, 0, 0}}};


    //TEEN 
    public static int[,,] teenResult = new int[6, 3, 5] { {{-5, 5, -5, 0, 0} // Teen 1
                                                          , {5, -5, -5, 0, 0}
                                                          , {-5, -5, 0, 0, 5}}

                                                          , {{0, -10, 0, 0, 5} // Teen 2  
                                                          , {0, 5, 0, 0, -5},
                                                           {0, 0, 0, 0, 0}}
                                                            
                                                          , {{-10, 5, 0, 0, 0} // Teen 3  
                                                          , {10, -5, 0, 0, 0},
                                                           {0, -10, 0, 0, 10}}

                                                          , {{0, 0, -10, 0, 0} // Teen 4  
                                                          , {0, 0, 10, 0, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 5, 0, 5, 0} // Teen 5  
                                                          , {0, 0, 0, 0, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 0, 0, -5, 0} // Teen 6  
                                                          , {0, 0, 0, 5, 5},
                                                           {0, 0, 0, -5, 0}}};

    public static int[,,] teen1frResult = new int[1, 3, 5] { {{0,5, 0, 0, -5} // Teen 1fr1
                                                          , {0, -5, 0, 0, 5}
                                                          , {-5, 0, 0, -5, 0}} };

    public static int[,,] teen2frResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Teen 2fr1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };

    public static int[,,] teen1enResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Teen 1en1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };


    //Adult
    public static int[,,] adultResult = new int[6, 3, 5] { {{5, 0, -5, 0, 0} // Adult 1
                                                          , {-5, 0, 5, 0, 0}
                                                          , {5, -5, 0, 0, 0}}

                                                          , {{0, 0, 0, 5, 0} // Adult 2 
                                                          , {0, 0, 0, -5, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 5, 0, 0, 0} // Adult 3 
                                                          , {0, -5, 0, 0, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{5, -5, 0, 0, 0} // Adult 4  
                                                          , {0, 0, 0, 0, 5},
                                                           {-5, -5, 0, 0, 0}}

                                                          , {{-5, 10, 0, 0, 0} // Adult 5  
                                                          , {0, -5, 0, 0, -5},
                                                           {0, 5, 0, 5, 0}}

                                                          , {{0, 0, 0, 5, 0} // Adult 6  
                                                          , {0, 0, 0, 0, 0},
                                                           {0, 0, 0, 0, 0}}};

    public static int[,,] adult1frResult = new int[1, 3, 5] { {{10, 0, -0, 0, 0} // Adult 1fr1
                                                          , {-5, 0, 0, -5, 0}
                                                          , {0, 0, 0, 0, 0}} };

    public static int[,,] adult2frResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Adult 2fr1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };

    public static int[,,] adult1enResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Adult 1en1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };


    //Elder
    public static int[,,] elderResult = new int[6, 3, 5] { {{0, 0, 0, 0, -5} // Elder 1 
                                                          , {0, 0, 5, 0, 0}
                                                          , {0, 5, 0, 0, 0}}

                                                          , {{0, -10, 0, 0, 0} // Elder 2 
                                                          , {0, 10, 0, 0, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 0, -5, 0, 0} // Elder 3 
                                                          , {0, 0, 0, 5, 0},
                                                           {0, 0, 0, 0, 0}}

                                                          , {{0, 5, 0, 0, 0} // Elder 4 
                                                          , {0, 0, 5, 0, 0},
                                                           {0, 0, 0, 0, 0} }

                                                          , {{0, -10, 0, 0, 0} // Elder 5  
                                                          , {-5, 5, 0, 0, -5},
                                                           {0, 0, 5, 5, 0}}

                                                          , {{0, 5, 0, 5, 0} // Elder 6  
                                                          , {0, 0, 5, 0, 0},
                                                           {0, 0, 0, 0, 0}}};


    public static int[,,] elder1frResult = new int[1, 3, 5] { {{0, 5, 0, -5, 0} // Elder 1fr1
                                                          , {0, -5, 0, -5, 0}
                                                          , {0, 5, 0, 5, 0}} };

    public static int[,,] elder2frResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Elder 2fr1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };

    public static int[,,] elder1enResult = new int[1, 3, 5] { {{0, 0, 0, 0, 0} // Elder 1en1
                                                          , {0, 0, 0, 0, 0}
                                                          , {0, 0, 0, 0, 0}} };


}