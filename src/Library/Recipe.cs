//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*
        <summary>
        Siguiendo el principio Expert la responsabilidad de conseguir el costo de produccion deberia ser parte de la clase Recipe
        Esto se debe a que la clase Recipe es la que posee la informacion necesaria para calcular el costo total
        </summary>
        */
        public double GetProductionCost()
        {
            /*
            <summary>
            Costo de insumos = Sumatoria de costo unitario de los insumos
            Costo de equipamiento = Sumatoria de tiempo de uso * costo/hora del equipo por cada paso de la receta
            Costo total = Costo de insumos + costo de equipamiento
            </summary>
            */
            double materialcost = 0;
            double equipmentcost = 0;
            
            foreach (Step unitstep in this.steps)
            {
                materialcost = materialcost + unitstep.MaterialCost;
                equipmentcost = equipmentcost + unitstep.EquipmentCost;
            }

            return materialcost + equipmentcost;
        }
    }
}