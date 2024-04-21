Точка входа `SlsDemo.Handler`.

## Сборка и запуск
```bash
FUNCTION_NAME=sls-demo

yc serverless function  create \
  --name $FUNCTION_NAME 
yc serverless function allow-unauthenticated-invoke $FUNCTION_NAME
```

```bash
dotnet build
cd SlsDemo/bin/Release/net8.0
zip -r SlsDemo.zip SlsDemo.dll

FUNCTION_NAME=sls-demo

yc serverless function version create \
  --function-name=$FUNCTION_NAME \
  --runtime dotnet8 \
  --entrypoint SlsDemo.Handler \
  --memory 128m \
  --execution-timeout 1s \
  --source-path ./SlsDemo.zip
```

## Тестирование
```bash
FUNCTION_NAME=sls-demo
id=`yc serverless function get $FUNCTION_NAME --format json | jq -r '.id'`
curl -X POST -H "Content-Type: application/json" -d '{"name":"World"}' https://functions.yandexcloud.net/$id
```