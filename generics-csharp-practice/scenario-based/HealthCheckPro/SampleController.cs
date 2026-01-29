using System;

namespace HealthCheckPro
{
    public class LabTestController
    {
        [PublicAPI]
        public void GetAllLabTests()
        {
            // Method to get all lab tests - public API
        }

        [RequiresAuth]
        public void GetPatientLabTest(int patientId)
        {
            // Method to get lab test for a patient - requires authentication
        }

        [RequiresRole("Admin")]
        public void UpdateLabTest(int testId, string result)
        {
            // Method to update lab test result - requires admin role
        }

        public void DeleteLabTest(int testId)
        {
            // Method to delete lab test - missing annotation (will be flagged)
        }
    }
}
