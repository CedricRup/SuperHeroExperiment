package com.heroCorp;

public class Event {
    private String type;
    private String location;
    private int strength;

    private Event(){}

    public Event(String type, String location, int strength) {
        this.type = type;
        this.location = location;
        this.strength = strength;
    }

    public String getType() {
        return type;
    }

    public String getLocation() {
        return location;
    }

    public int getStrength() {
        return strength;
    }
}
