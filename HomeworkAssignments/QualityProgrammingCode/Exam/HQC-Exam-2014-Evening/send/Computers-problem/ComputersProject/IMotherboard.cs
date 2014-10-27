//-----------------------------------------------------------------------

// <copyright file="IMotherboard.cs" company="CompanyName">

// Company copyright tag.

// </copyright>

//-----------------------------------------------------------------------

namespace System
{
    /// <summary>
    /// This interface does nothing, except for baking cookies.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// This method gets the prefabricated cookies from the store.
        /// </summary>
        /// <returns>Prefabricated cookies.</returns>
        int LoadRamValue();

        /// <summary>
        /// This method turns on the oven and puts in the cookies... yeah yeah... I know that one method should do only one thing...
        /// </summary>
        /// <param name="value">Degrees of the oven.</param>
        void SaveRamValue(int value);

        /// <summary>
        /// This method gets the cookies from the oven, when they are ready and gives you the desired amount. Enjoy.
        /// </summary>
        /// <param name="data">Desired amount of cookies.</param>
        void DrawOnVideoCard(string data);
    }
}
