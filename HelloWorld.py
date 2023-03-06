# Basic hello world to demonstrate FastAPI is installed correctly. Run via command "uvicorn HelloWorld:hello_api --reload"

from fastapi import FastAPI

hello_api = FastAPI()

@hello_api.get("/")
async def root():
    return {"message": "Hello World"}

@hello_api.get("/names/{name}")
async def read_name(name):
    return {"message": f"Hello, {name}"}
