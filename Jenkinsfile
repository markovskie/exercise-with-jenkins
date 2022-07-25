pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                bat "dotnet build" //building the app
                echo "App is building"
            }
        }
        stage('Publish') {
            steps {
                bat "del /F /Q /S C:\\inetpub\\wwwroot\\emawebsite\\" // deleting existing files from folder
                bat "cd D:\\Documents\\Ema\\first_dotnet_ex\\exercise-with-jenkins\\MyWebApp" //positioning in the app folder
                bat "dotnet publish --output C:\\inetpub\\wwwroot\\emawebsite\\" //publish the app in IIS folder

            }
        }
        stage('Zip app') {
            steps {
                bat "powershell Compress-Archive D:\Documents\Ema\first_dotnet_ex\exercise-with-jenkins\MyWebApp\bin\Release\net6.0\publish D:\Documents\Ema\first_dotnet_ex\exercise-with-jenkins\MyWebApp\bin\Release\net6.0\publish.zip"
            }
        }
        stage('Push zip to Jfrog') {
            steps {
                echo 'Deploying....'
            }
        }        
    }
}
    