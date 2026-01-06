import requests
import json

base_url = "http://localhost:5216"
login_payload = {"Username": "admin", "Password": "1234"}

print(f"Testing Login at {base_url}/api/auth/login...")
response = requests.post(f"{base_url}/api/auth/login", json=login_payload)
print(f"Login Status: {response.status_code}")

if response.status_code == 200:
    token = response.json().get("token")
    print(f"Token obtained: {token[:10]}...")
    
    headers = {"Authorization": f"Bearer {token}"}
    print(f"Testing GET {base_url}/api/users with token...")
    users_response = requests.get(f"{base_url}/api/users", headers=headers)
    print(f"Users Status: {users_response.status_code}")
    print(f"Response: {users_response.text}")
else:
    print(f"Login failed: {response.text}")
