from doctest import debug

from flask import Flask, request, jsonify, make_response
from flask_cors import CORS
import pandas as pd
import joblib
import numpy as np

# import os

app = Flask(__name__)   
CORS(app)

# Load the pre-trained model
model_path = ("A:/Project X/Data Science/Esoft/Semester 03/UNIT_24 - Advanced "
              "Programming For Data Analytics/Assignments/Iris Flower "
              "Classification Application/irisflowerclassification"
              "/flusk_server/artifacts/saved_trained_model.pkl")

model = joblib.load(model_path)

# Define the route for prediction
@app.route('/', methods=['POST', 'OPTIONS'])

# Function to get the data

def predict():
    if request.method == 'OPTIONS':
        # Handle preflight request
        response = make_response()
        response.headers.add('Access-Control-Allow-Origin', '*')
        response.headers.add('Access-Control-Allow-Headers', 'Content-Type,Authorization')
        response.headers.add('Access-Control-Allow-Methods', 'POST,OPTIONS')
        return response, 200

    elif request.method == 'POST':
        try:
            data = request.json
            print("Received data:", data)

            # Validate input data
            required_fields = ['sepal_length', 'sepal_width', 'petal_length', 'petal_width']
            for field in required_fields:
                if field not in data:
                    return jsonify({'error': f'Missing field {field}'}), 400

            input_data = pd.DataFrame([data])

            # Ensure all values are numeric
            input_data = input_data.astype(float)

            prediction = model.predict(input_data)
            print("Raw prediction result:", prediction)

            class_mapping = {
                0: 'Iris-setosa',
                1: 'Iris-versicolor',
                2: 'Iris-virginica'
            }

            # Convert numpy.int32 to native Python int
            prediction_code = int(prediction[0])
            prediction_label = class_mapping.get(prediction_code, 'Unknown')
            return jsonify({'prediction': prediction_label})

        except Exception as e:
            print("Error during prediction:", str(e))
            return jsonify({'error': 'Internal server error'}), 500
    else:
        return 'Method not allowed', 405

if __name__ == "__main__":
    app.run(debug=True)




