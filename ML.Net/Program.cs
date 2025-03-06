// See https://aka.ms/new-console-template for more information
using ML_Net;

//Load sample data
var sampleData = new MLModelTest.ModelInput()
{
    Col0 = @"Crust is not good.",
};

//Load model and predict output
var result = MLModelTest.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

