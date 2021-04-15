import { Meta, Story } from "@storybook/react/types-6-0";
import TextInput from "../components/TextInput";

export default {
    title: "components/TextInput",
    components: TextInput,
} as Meta;

const Template: Story = () => <TextInput />;

export const Default = Template.bind({});