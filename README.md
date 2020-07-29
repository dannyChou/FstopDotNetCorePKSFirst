# NetCoreMicroserviceDemo

```
sudo docker run -d -p 9060:80 --name orderservice orderapi:1.0 --ConsulSetting:ServicePort="9060" --ConsulSetting:ServiceIP="172.20.10.2"
sudo docker run -d -p 9061:80 --name orderservice1 orderapi:1.0 --ConsulSetting:ServicePort="9061" --ConsulSetting:ServiceIP="172.20.10.2"
sudo docker run -d -p 9062:80 --name orderservice2 orderapi:1.0 --ConsulSetting:ServicePort="9062" --ConsulSetting:ServiceIP="172.20.10.2"

sudo docker build -t productapi:1.2 -f ./Product.API/Dockerfile .
sudo docker run -d -p 9050:80 --name productservice productapi:1.2 --ConsulSetting:ServicePort="9050" --ConsulSetting:ServiceIP="172.20.10.2"
sudo docker run -d -p 9051:80 --name productservice1 productapi:1.2 --ConsulSetting:ServicePort="9051" --ConsulSetting:ServiceIP="172.20.10.2"
sudo docker run -d -p 9052:80 --name productservice2 productapi:1.2 --ConsulSetting:ServicePort="9052" --ConsulSetting:ServiceIP="172.20.10.2"


sudo docker build -t mymvcweb -f ./Product.API/Dockerfile .
sudo docker run -d -p 9070:80 --name mvcweb mymvcweb --ConsulSetting:ConsulAddress="http://172.20.10.2:8500"

--刪除所有的 name = orderservice productservice 的Container
sudo docker rm -f $(sudo docker ps --filter name=orderservice* -q)
sudo docker rm -f $(sudo docker ps --filter name=productservice* -q)
```

