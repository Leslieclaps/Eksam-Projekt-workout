
using UnityEngine;
using TMPro;

using UnityEngine.UI; // Required for dealing with UI components
 
public class InputHandler : MonoBehaviour

{
    private HideUnhide hideunhide = new HideUnhide();
    private int[] workoutArray;
    public TMP_InputField inputField; // Reference to the input field
    public GameObject[] workoutButtons;
    public GameObject[] inputButtons;

    public Button NumberOfWorkoutsSubmitButton;   // Reference to the button

    void Start()

    {
        hideunhide.Hide(workoutButtons);

        // Add a listener to the button to trigger the function when clicked

        NumberOfWorkoutsSubmitButton.onClick.AddListener(OnSubmit);

    }

    void OnSubmit()

    {

        if (int.TryParse(inputField.text, out int inputValue))

        {

            if (inputValue <= 3)
            {
                //If the input is a valid integer and less than 3, run the desired function
                ProcessInput(inputValue);
                

            }
            else
            {
                Debug.Log("Input must be less than 3. Please try again.");
            }

        }

        else

        {

            Debug.Log("Invalid input. Please enter a valid integer.");

        }

    }

    // Function that processes the input integer in some way

    void ProcessInput(int inputValue)

    {

        // Example processing code

        Debug.Log("Processing input value: " + inputValue);
        workoutArray= new int[inputValue];
        hideunhide.UnHide(workoutButtons);
        hideunhide.Hide(inputButtons);
        // Add your specific processing logic here

    }

}
