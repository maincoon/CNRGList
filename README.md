﻿# Prerequests

wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-3.1


# Create project

git clone https://github.com/maincoon/CNRGList.git
cd CNRGList
dotnet build

# Running

dotnet run
Usage: CNRGList <num> <min> <max>

# Creating 10 addresses with keys min 50 max 60

dotnet run 10 50 60
