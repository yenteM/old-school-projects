using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsianOptions
{

	/// <summary>
	/// Calculates the price of an asian options based on the given statistical context.
	/// </summary>
	public class AsianOptionsPricing
	{

		/// <summary>
		/// Calculates the price of an option with the given statistical info.
		/// The algorithm used for calculation is the Monte Carlo method.
		/// </summary>
		/// <param name="rand">Random number generator.</param>
		/// <param name="initial">Initial price.</param>
		/// <param name="exercise">Excercise price.</param>
		/// <param name="up">Up growth.</param>
		/// <param name="down">Down growth.</param>
		/// <param name="interest">Intrest rate.</param>
		/// <param name="periods">Number of periods to maturity.</param>
		/// <param name="sims">Number of simulations to perform.</param>
		/// <returns>The calculated value for an option with the given 
		/// statistical context using the Monte Carlo method.</returns>
		///
		public static double Simulation(Random rand, double initial, double exercise, double up, double down, double interest, long periods, long sims)
		{
			// Risk-neutral probabilities:
			double piup = (interest - down) / (up - down);
			double pidown = 1 - piup;

			double sum = 0.0;

			// Run simulations:
			for (int index = 0; index < sims; index++)
			{
				// Generate one path:
				double sumPricePath = initial;
				double previous = initial;
				double next;

				for (int i = 1; i <= periods; i++)
				{
					double rn = rand.NextDouble();

					if (rn > pidown)
					{
						next = previous * up;
					}
					else
					{
						next = previous * down;
					}

					sumPricePath += next;
					previous = next;
				}

				double priceAverage = sumPricePath / (periods + 1);
				double callPayOff = Math.Max(priceAverage - exercise, 0);

				sum += callPayOff;
			}

			// Return average across all simulations:
			return (sum / Math.Pow(interest, periods)) / sims;
		}

	}//class
}//namespace