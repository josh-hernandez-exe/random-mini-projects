FROM python:3.11.9

RUN pip install pipenv

# Create and switch to a new user
RUN useradd --create-home appuser
WORKDIR /home/appuser
USER appuser

COPY Pipfile .
COPY Pipfile.lock .
RUN pipenv install

# Install application into container
COPY . .
