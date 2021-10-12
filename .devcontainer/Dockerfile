FROM mcr.microsoft.com/dotnet/sdk:5.0.401

# Install missing ps command (used by some VSCode extensions)
RUN apt-get update && \
    apt-get install -y procps

# -m creates a home dir for harry
# setting default shell as bash
RUN useradd -m -s $(which bash) harry

# Create working directory and bestow the
# ownership upon harry
RUN mkdir /harry-potter && \
    chown harry:harry /harry-potter
