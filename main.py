from fastapi import FastAPI
from .core import models as Models
from .core import service_core as Service

rest_api = FastAPI()

# TODO: Move routing logic to a facade file.

@rest_api.get('/score/{level_id}', response_model = list[Models.Score])
def level_hi_score(level_id : str, limit : int = 10):
    return Service.level_hi_score(level_id=level_id, limit=limit)

@rest_api.post('/score/{level_id}/submit')
def submit_hi_score(level_id : str, user_id : str, score : int):
    return {"result": Service.submit_hi_score(level_id=level_id, user_id=user_id,score=score)} 
