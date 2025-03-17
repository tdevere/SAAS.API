#!/bin/bash
echo "Waiting for PostgreSQL to become available..."
until nc -z postgres 5432; do
  sleep 2
done
echo "PostgreSQL is up - starting API..."
dotnet SaaS.Api.dll
