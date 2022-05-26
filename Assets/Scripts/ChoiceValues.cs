using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceValues : MonoBehaviour
{
    // {Career, Popularity, Health, Life Skills, Morals}
    public static int[,,] arr = new int[8, 3, 5] { {{0, 0, -5, 0, -5} // Scenario 1
                                              , {0, 5, 0, 0, 5}
                                              , {0, 0, 0, 0, 0}}
                                            , {{0, 0, 0, 0, -5} // Scenario 2
                                              , {0, 0, 0, 10, -5},
                                                {0 , 10, -5, 5, 0}}
                                            , {{5, -5, -5, 5, 0} // Scenario 3
                                              , {-5, -5, 5, 0, 0}
                                              , {5, -10, 0, 0, 5}}
                                            , {{5, -10, 0, 0, 5} // Scenario 4
                                              , {0, 5, 5, 0, -5}
                                              , {0, 0, 0, 0, 0}}
                                            , {{5, 0, -5, 0, 0} // Scenario 5
                                              , {-5, 0, 5, 0, 0}
                                              , {5, -5, 0, 0, 0}}
                                            , {{0, 0, 0, 5, 0} // Scenario 6
                                              , {0, 0, 0, -5, 0}
                                              , {0, 0, 0, 0, 0}} 
                                            , {{0, 0, 0, 0, -5} // Scenario 7
                                              , {0, 0, 5, 0, 0}
                                              , {0, 5 ,0, 0, 0}}
                                            , {{0, -10, 0, 0, 0} // Scenario 8
                                              , {0, 10, 0, 0, 0}
                                              , {0, 0, 0, 0, 0}}};
}
