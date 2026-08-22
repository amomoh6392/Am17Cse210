import csv
from datetime import datetime

def main():
    filename = "Machine_log.csv"
    create_log_file(filename)

    while True:
        print("=== predictive Maintenance System ===")
        print("1. Check Machine")
        print("2. View Logs")
        print("3. Exit")

        choice = input("choose an option:")

        if choice == "1":
            temp, vibration = get_user_input()

            temp_status = evaluate_temperature(temp)
            vib_status = evaluate_vibration(vibration)

            result = overall_status(temp_status, vib_status)

            display_result (result)
            log_data(filename, temp, vibration, result) 
        elif choice == "2":
            print(" --- Machine Logs ---")
            print(read_logs(filename))
        elif choice == "3":
            print("Goodbye! And Thank You")
            break
        else:
            print("Invalid Choice")

def evaluate_temperature(temp):
    if temp >= 90:
        return "critical"
    elif temp >= 70:
        return "warning"
    else:
        return "normal"
    
def evaluate_vibration(vibration):
    if vibration >= 7:
        return "critical"
    elif vibration >= 4:
        return "warning"
    else:
        return "normal"
    
def overall_status(temp_status, vib_status):
    if "critical" in (temp_status, vib_status):
        return "CRITICAL: Immediate maintenance required!"
    elif "warning" in (temp_status,vib_status):
        return "WARNING: Check machine soon."
    else:
        return "NORMAL: Machine is running well."
    
def get_user_input():
   while True:
        try:
            temp = float(input("Enter temperature (°C): "))
            vibration = float(input("Enter vibration level: "))
            return temp, vibration
        except ValueError:
            print("Please enter valid numbers.")

def display_result(result):
    print(f" Machine Status: {result}" )

def log_data(filename, temp, vibration, status):
    with open(filename, "a", newline = "")as file:
        writer = csv.writer(file)
        writer.writerow([datetime.now(), temp, vibration, status])

def create_log_file(filename):
    try:
        with open(filename, "x", newline = "") as file:
            writer = csv.writer(file)
            writer.writerow(["Timestamp", "Temperature", "vibration", "Status"])
    except FileExistsError:
        pass

def read_logs(filename):
    try:
        with open(filename, "r") as file:
            return file.read()
    except FileNotFoundError:
        return "No Log file found"
    

if __name__ == "__main__":
    main()