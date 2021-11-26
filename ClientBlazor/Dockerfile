FROM nginx:alpine
WORKDIR /var/www/web
COPY ClientBlazor/dist/wwwroot .
COPY ClientBlazor/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80