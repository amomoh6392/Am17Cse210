from predictive_maintenance import(evaluate_temperature, evaluate_vibration, overall_status)
import pytest
def test_evaluation_temperature():
    assert evaluate_temperature(90) == "critical"
    assert evaluate_temperature(70) == "warning"
    assert evaluate_temperature(50) == "normal"

def test_evaluation_vibration():
    assert evaluate_vibration(7) == "critical"
    assert evaluate_vibration(4) == "warning"
    assert evaluate_vibration(2) == "normal"

def test_overall_status():
    assert overall_status("critical", "normal") == "CRITICAL: Immediate maintenance required!"
    assert overall_status("warning", "normal") == "WARNING: Check machine soon."
    assert overall_status("normal", "normal") == "NORMAL: Machine is running well."

pytest.main(["-v", "--tb=line", "-rN", __file__])