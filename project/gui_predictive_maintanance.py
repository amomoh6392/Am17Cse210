import tkinter as tk
from predictive_maintenance import (
    evaluate_temperature, 
    evaluate_vibration, 
    overall_status, 
    log_data, 
    create_log_file, 
    read_logs
)

filename = "Machine_log.csv"
create_log_file(filename)

def check_machine():
    try:
        temp = float(temp_entry.get())
        vibration = float(vib_entry.get())

        temp_status = evaluate_temperature(temp)
        vib_status = evaluate_vibration(vibration)

        result = overall_status(temp_status, vib_status)

        log_data(filename, temp, vibration, result)

        result_label.config(text=result)

    except ValueError:
        result_label.config(text="Enter valid numbers!")

def view_logs():
    logs = read_logs(filename)

    log_window = tk.Toplevel(window)
    log_window.title("Machine Logs")
    log_window.geometry("500x400")

    scrollbar = tk.Scrollbar(log_window)
    scrollbar.pack(side="right", fill="y")

    text_area = tk.Text(log_window, wrap="none")
    text_area.insert("1.0", logs)
    text_area.pack(expand=True, fill="both")

    scrollbar.config(command=text_area.yview)

window = tk.Tk()
window.title("Predictive Maintenance System")
window.geometry("350x250") 

window.columnconfigure(0, weight=1)
window.columnconfigure(1, weight=1)

tk.Label(window, text="Temperature (°C)").grid(row=0, column=0, padx=10, pady=10, sticky="e")
temp_entry = tk.Entry(window, width=10)
temp_entry.grid(row=0, column=1, padx=10, pady=10, sticky="w")

tk.Label(window, text="Vibration").grid(row=1, column=0, padx=10, pady=10, sticky="e")
vib_entry = tk.Entry(window, width=10)
vib_entry.grid(row=1, column=1, padx=10, pady=10, sticky="w")

tk.Button(window, text="Check Machine", command=check_machine).grid(row=2, column=0, columnspan=2, pady=10)
tk.Button(window, text="View Logs", command=view_logs).grid(row=3, column=0, columnspan=2, pady=5)

result_label = tk.Label(window, text="", font=("Arial", 12, "bold"))
result_label.grid(row=4, column=0, columnspan=2)

window.mainloop()