# Use the official Nginx image from the Docker Hub
FROM nginx:alpine

# Copy custom Nginx configuration file
COPY nginx.conf /etc/nginx/nginx.conf

# Copy the static content
COPY src /usr/share/nginx/html