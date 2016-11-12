﻿/*  HEADER
 * 
 * ELEMENT CLASS  
 *  A high level class to inherit from.  Provides fields that all model elements must have.
 *  
 *  3/3/15
 *  
 * Ana Garcia Puyol
 *  
 */

using System;

namespace RCva3c
{

    public class Material
    {
        //ATTRIBUTES

        private string myID;

        public va3cMaterialType Type { get; set; }

        public string MaterialJson { get; set; }


        //PROPERTIES
        public string ID
        {
            get { return myID; }
            set
            {
                try
                {
                    //test for the empty string
                    if (value == "")
                    {
                        throw new ArgumentException("The input string cannot be empty");
                    }

                    myID = value;
                }

                catch (Exception e) //should catch the null case
                {
                    throw e;
                }
            }
        }

        //constructors

        public Material() { }

        public Material(string json, va3cMaterialType type)
        {
            Type = type;
            MaterialJson = json;
        }

        
    }
    public enum va3cMaterialType
    {
        Mesh,
        Line
    }
}
