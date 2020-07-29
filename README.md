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

```

##### --刪除所有的 name = orderservice productservice 的Container

```
sudo docker rm -f $(sudo docker ps --filter name=orderservice* -q)
sudo docker rm -f $(sudo docker ps --filter name=productservice* -q)

sudo docker rm $(sudo docker ps -a --filter name=orderservice* -q)
sudo docker rm $(sudo docker ps -a --filter name=productservice* -q)

sudo docker start $(sudo docker ps -a --filter name=orderservice* -q)
sudo docker start $(sudo docker ps -a --filter name=productservice* -q)
```

## Consul

```
Consul
Consul官网：https://www.consul.io/
Consul的主要功能有服务注册与发现、健康检查、K-V存储、多数据中心等。

Consul安装：很简单，直接在官网下载解压即可。
Consul运行：在consul.exe目录下打开命令行执行 consul.exe agent -dev
浏览器访问：http://localhost:8500/

https://www.cnblogs.com/xishuai/p/macos-ubuntu-install-consul.html
啟動Consul的指令
consul agent -server -bootstrap-expect 1 -data-dir /tmp/consul -ui  -config-dir /etc/consul.d -bind=172.20.10.2

```

使用命令執行Dotnet

```
目前不考虑网关集群，就不放在docker里了。直接控制台执行：`dotnet Ocelot.APIGateway.dll --urls="http://*:9070"
```

